CREATE EXTENSION IF NOT EXISTS pgcrypto;

DROP TABLE IF EXISTS  stages, stage_names, themes, students, _groups, teachers, teacher_types, users;

CREATE TABLE teacher_types (
	type_id         integer GENERATED ALWAYS AS IDENTITY NOT NULL,
	type_name       varchar(128)
);

ALTER TABLE teacher_types 
  ADD CONSTRAINT pk_teacher_types PRIMARY KEY (type_id);

CREATE TABLE teachers (
	teacher_id      integer GENERATED ALWAYS AS IDENTITY NOT NULL,
	type_id         integer NOT NULL,
	teacher_name    varchar(128) NOT NULL,
	address         varchar(128) NOT NULL,
	phone           varchar(32) NOT NULL
);

ALTER TABLE teachers
	ADD CONSTRAINT pk_teachers PRIMARY KEY (teacher_id),
	ADD CONSTRAINT fk_teachers_teacher_types_type_id FOREIGN KEY (type_id) REFERENCES teacher_types;

CREATE TABLE _groups (
	group_id        integer GENERATED ALWAYS AS IDENTITY NOT NULL,
	teacher_id      integer NOT NULL,
	group_name      varchar(32) NOT NULL,
	year_started    integer NOT NULL
);

ALTER TABLE _groups 
	ADD CONSTRAINT pk_groups PRIMARY KEY (group_id),
	ADD CONSTRAINT fk_groups_teachers_teacher_id FOREIGN KEY (teacher_id) REFERENCES teachers;

CREATE TABLE students (
	student_id      integer GENERATED ALWAYS AS IDENTITY NOT NULL,
	group_id        integer NOT NULL,
	student_name    varchar(128) NOT NULL,
	phone           varchar(32) NOT NULL
);

ALTER TABLE students 
	ADD CONSTRAINT pk_students PRIMARY KEY (student_id),
	ADD CONSTRAINT fk_students_groups_group_id FOREIGN KEY (group_id) REFERENCES _groups;

CREATE TABLE users (
	user_id         integer GENERATED ALWAYS AS IDENTITY NOT NULL,
	teacher_id      integer,
	student_id      integer,
	pass_hash       varchar(60) NOT NULL
);

ALTER TABLE users 
	ADD CONSTRAINT pk_users PRIMARY KEY (user_id),
	ADD CONSTRAINT fk_users_teachers_teacher_id FOREIGN KEY (teacher_id) REFERENCES teachers,
	ADD CONSTRAINT fk_users_students_student_id FOREIGN KEY (student_id) REFERENCES students,
	ADD CONSTRAINT valid_user CHECK ((student_id IS NULL) != (teacher_id IS NULL)),
	ADD CONSTRAINT u_teacher_id UNIQUE (teacher_id),
	ADD CONSTRAINT u_student_Id UNIQUE (student_id);

CREATE TABLE themes (
	theme_id        integer GENERATED ALWAYS AS IDENTITY NOT NULL,
	student_id      integer NOT NULL,
	theme_name      varchar(128) NOT NULL,
	main_teacher_id integer NOT NULL,
	econ_teacher_id integer NOT NULL,
	safe_teacher_id integer NOT NULL
);

ALTER TABLE themes
	ADD CONSTRAINT pk_themes PRIMARY KEY (theme_id),
	ADD CONSTRAINT fk_themes_students_student_id FOREIGN KEY (student_id) REFERENCES students,
	ADD CONSTRAINT fk_themes_teachers_main_teacher_id FOREIGN KEY (main_teacher_id) REFERENCES teachers (teacher_id),
	ADD CONSTRAINT fk_themes_teachers_econ_teacher_id FOREIGN KEY (econ_teacher_id) REFERENCES teachers (teacher_id),
	ADD CONSTRAINT fk_themes_teachers_safe_teacher_id FOREIGN KEY (safe_teacher_id) REFERENCES teachers (teacher_id),
	ADD CONSTRAINT u_theme_name UNIQUE (theme_name);

CREATE TABLE stage_names (
	stage_name_id   integer GENERATED ALWAYS AS IDENTITY NOT NULL,
	stage_name      varchar(128) NOT NULL
);

ALTER TABLE stage_names
	ADD CONSTRAINT pk_stage_names PRIMARY KEY (stage_name_id);

CREATE TABLE stages (
	stage_id        integer GENERATED ALWAYS AS IDENTITY NOT NULL,
	stage_name_id   integer NOT NULL,
	theme_id        integer NOT NULL,
	teacher_id      integer NOT NULL,
	percentage      integer NOT NULL DEFAULT (0),
	date_started    date NOT NULL DEFAULT(CURRENT_DATE),
	date_ended      date
);

ALTER TABLE stages 
	ADD CONSTRAINT pk_stages PRIMARY KEY (stage_id),
	ADD CONSTRAINT fk_stages_stage_names_stage_name_id FOREIGN KEY (stage_name_id) REFERENCES stage_names,
	ADD CONSTRAINT fk_stages_themes_theme_id FOREIGN KEY (theme_id) REFERENCES themes,
	ADD CONSTRAINT fk_stages_teachers_teacher_id FOREIGN KEY (teacher_id) REFERENCES teachers;


DROP FUNCTION IF EXISTS
	add_teacher_type, update_teacher_type, delete_teacher_type, add_teacher, update_teacher, delete_teacher, 
	add_group, update_group, delete_group, add_student, update_student, delete_student, add_theme, update_theme, 
	delete_theme, add_stage_name, update_stage_name, delete_stage_name, add_stage, update_stage, delete_stage, 
	get_teacher_types, get_teachers, get_groups, get_students, get_users, get_themes, get_stage_names, get_stages,
	check_password;

CREATE FUNCTION add_teacher_type (_type_name varchar(128))
RETURNS void
AS $$
BEGIN
	INSERT INTO teacher_types (type_name)
	VALUES (_type_name);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION update_teacher_type (_type_id integer, _type_name varchar(128))
RETURNS void
AS $$
BEGIN 
	UPDATE teacher_types 
	SET type_name = _type_name
	WHERE type_id = _type_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION delete_teacher_type (_type_id integer)
RETURNS void 
AS $$
BEGIN
	DELETE FROM teacher_types
	WHERE type_id = _type_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION add_teacher (
	_type_id		integer,
	_teacher_name	varchar(128),
	_address		varchar(128),
	_phone			varchar(32),
	_pass			varchar(128)
) 
RETURNS void
AS $$
DECLARE 
	new_teacher_id	integer;
BEGIN
	INSERT INTO teachers (type_id, teacher_name, address, phone)
	VALUES (_type_id, _teacher_name, _address, _phone)
	RETURNING teacher_id INTO new_teacher_id;

	INSERT INTO users (teacher_id, pass_hash)
	VALUES (new_teacher_id, crypt(_pass, gen_salt('bf', 8)));
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION update_teacher (
	_teacher_id		integer,
	_type_id		integer,
	_teacher_name	varchar(128), 
	_address		varchar(128),
	_phone			varchar(32),
	_pass			varchar(128)
)
RETURNS void
AS $$
DECLARE 
	old_pass		varchar(60);
BEGIN
	old_pass = (SELECT pass_hash FROM users WHERE teacher_id = _teacher_id);
	IF crypt(_pass, old_pass) != old_pass THEN 
		UPDATE users 
		SET pass_hash = crypt(_pass, gen_salt('bf', 8))
		WHERE teacher_id = _teacher_id;
	END IF;

	UPDATE teachers 
	SET 
		type_id = _type_id, teacher_name = _teacher_name, 
		address = _address, phone = _phone
	WHERE teacher_id = _teacher_id;
END;
$$ LANGUAGE 'plpgsql';


CREATE FUNCTION delete_teacher (_teacher_id integer)
RETURNS void
AS $$
BEGIN
	DELETE FROM users 
	WHERE teacher_id = _teacher_id;

	DELETE FROM teachers 
	WHERE teacher_id = _teacher_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION add_group (
	_teacher_id 	integer,
	_group_name		varchar(32),
	_year_started 	integer
)
RETURNS void
AS $$
BEGIN
	INSERT INTO _groups (teacher_id, group_name, year_started)
	VALUES (_teacher_id, _group_name, _year_started);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION update_group (
	_group_id		integer,
	_teacher_id 	integer,
	_group_name		varchar(32),
	_year_started 	integer
)
RETURNS void
AS $$
BEGIN
	UPDATE _groups 
	SET
		teacher_id = _teacher_id, group_name = _group_name,
		year_started = _year_started
	WHERE group_id = _group_id;
END;
$$ LANGUAGE 'plpgsql';


CREATE FUNCTION delete_group (_group_id integer)
RETURNS void
AS $$
BEGIN
	DELETE FROM _groups 
	WHERE group_id = _group_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION add_student (
	_group_id		integer,
	_student_name	varchar(128),
	_phone			varchar(32),
	_pass			varchar(128)	
)
RETURNS void
AS $$
DECLARE 
	new_student_id	integer;
BEGIN
	INSERT INTO students (group_id, student_name, phone)
	VALUES (_group_id, _student_name, _phone)
	RETURNING student_id INTO new_student_id;

	INSERT INTO users (student_id, pass_hash)
	VALUES (new_student_id, crypt(_pass, gen_salt('bf', 8)));
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION update_student (
	_student_id		integer,
	_group_id		integer,
	_student_name	varchar(128),
	_phone			varchar(32),
	_pass			varchar(128)	
)
RETURNS void
AS $$
DECLARE
	old_pass		varchar(60);
BEGIN
	old_pass = (SELECT pass_hash FROM users WHERE student_id = _student_id);
	IF crypt(_pass, old_pass) != old_pass THEN 
		UPDATE users 
		SET pass_hash = crypt(_pass, gen_salt('bf', 8))
		WHERE student_id = _student_id;
	END IF;

	UPDATE students
	SET 
		group_id = _group_id, student_name = _student_name, phone = _phone
	WHERE student_id = _student_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION delete_student (_student_id integer)
RETURNS void
AS $$
BEGIN
	DELETE FROM users
	WHERE student_id = _student_id;

	DELETE FROM students 
	WHERE student_id = _student_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION add_theme (
	_student_id			integer,
	_theme_name			varchar(128),
	_main_teacher_id	integer,
	_econ_teacher_id	integer,
	_safe_teacher_id	integer
)
RETURNS integer 
AS $$
BEGIN
	-- CODES: 
	-- 	0 - success
	-- -1 - teacher already has 8 themes
	
	IF (SELECT COUNT(*) FROM themes WHERE main_teacher_id = _main_teacher_id) >= 8 THEN
		RETURN -1;
	END IF;

	INSERT INTO themes (student_id, theme_name, main_teacher_id, econ_teacher_id, safe_teacher_id)
	VALUES (_student_id, _theme_name, _main_teacher_id, _econ_teacher_id, _safe_teacher_id);

	RETURN 0;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION update_theme (
	_theme_id			integer,
	_student_id			integer,
	_theme_name			varchar(128),
	_main_teacher_id	integer,
	_econ_teacher_id	integer,
	_safe_teacher_id	integer
)
RETURNS integer 
AS $$
BEGIN
	-- CODES: 
	-- 	0 - success
	-- -1 - teacher already has 8 themes
	
	IF (SELECT COUNT(*) FROM themes WHERE main_teacher_id = _main_teacher_id) >= 8 THEN
		RETURN -1;
	END IF;

	UPDATE themes 
	SET 
		student_id = _student_id, theme_name = _theme_name,
		main_teacher_id = _main_teacher_id, 
		econ_teacher_id = _econ_teacher_id,
		safe_teacher_id = _safe_teacher_id
	WHERE theme_id = _theme_id;

	RETURN 0;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION delete_theme (_theme_id integer)
RETURNS void
AS $$
BEGIN
	DELETE FROM themes
	WHERE theme_id = _theme_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION add_stage_name(_stage_name varchar(128))
RETURNS void 
AS $$
BEGIN 
	INSERT INTO stage_names (stage_name)
	VALUES (_stage_name);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION update_stage_name (_stage_name_id integer, _stage_name varchar(128))
RETURNS void
AS $$
BEGIN
	UPDATE stage_names 
	SET stage_name = _stage_name
	WHERE stage_name_id = _stage_name_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION delete_stage_name (_stage_name_id integer)
RETURNS void
AS $$
BEGIN
	DELETE FROM stage_names
	WHERE stage_name_id = _stage_name_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION add_stage (
	_stage_name_id	integer,
	_theme_id		integer,
	_teacher_id		integer,
	_percentage		integer,
	_date_started	date,
	_date_ended		date 

)
RETURNS void 
AS $$
BEGIN
	INSERT INTO stages (stage_name_id, theme_id, teacher_id, percentage, date_started, date_ended)
	VALUES (_stage_name_id, _theme_id, _teacher_id, _percentage, _date_started, _date_ended);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION update_stage (
	_stage_id 		integer,
	_stage_name_id	integer,
	_theme_id		integer,
	_teacher_id		integer,
	_percentage		integer,
	_date_started	date,
	_date_ended		date 
)
RETURNS void
AS $$
BEGIN 
	UPDATE stages 
	SET
		stage_name_id = _stage_name_id, theme_id = _theme_id,
		teacher_id = _teacher_id, percentage = _percentage, 
		date_started = _date_started, date_ended = _date_ended
	WHERE stage_id = _stage_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION delete_stage (_stage_id integer)
RETURNS void
AS $$
BEGIN
	DELETE FROM stages 
	WHERE stage_id = _stage_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION get_teacher_types ()
RETURNS TABLE (
	type_id		integer,
	type_name	varchar
)
AS $$
BEGIN
	RETURN QUERY 
	SELECT teacher_types.type_id, teacher_types.type_name
	FROM teacher_types;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION get_teachers ()
RETURNS TABLE (
	teacher_id		integer,
	type_id			integer,
	type_name		varchar,
	teacher_name	varchar,
	address			varchar,
	phone			varchar
)
AS $$
BEGIN
	RETURN QUERY
	SELECT 
		teachers.teacher_id, teachers.type_id, teacher_types.type_name,
		teachers.teacher_name, teachers.address, teachers.phone
	FROM teachers
	JOIN teacher_types USING (type_id);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION get_groups ()
RETURNS TABLE (
	group_id		integer,
	teacher_id		integer,
	teacher_name	varchar,
	group_name		varchar,
	year_started	integer
)
AS $$
BEGIN
	RETURN QUERY
	SELECT 
		_groups.group_id, _groups.teacher_id, teachers.teacher_name, 
		_groups.group_name, _groups.year_started
	FROM _groups
	JOIN teachers USING (teacher_id);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION get_students ()
RETURNS TABLE (
	student_id		integer,
	group_id		integer,
	group_name		varchar,
	student_name	varchar,
	phone			varchar
)
AS $$
BEGIN
	RETURN QUERY
	SELECT 
		students.student_id, students.group_id, _groups.group_name,
		students.student_name, students.phone
	FROM students
	JOIN _groups USING (group_id);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION get_users ()
RETURNS TABLE (
	user_id			integer,
	is_teacher		boolean,
	id				integer,
	name			varchar
)
AS $$
BEGIN
	RETURN QUERY 
	SELECT 
		users.user_id, users.teacher_id IS NOT NULL AS is_teacher, 
		COALESCE(users.teacher_id, users.student_id) AS id, 
		COALESCE(teachers.teacher_name, students.student_name) AS name
	FROM users
	LEFT JOIN teachers USING (teacher_id)
	LEFT JOIN students USING (student_id);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION get_themes ()
RETURNS TABLE (
	theme_id			integer,
	student_id			integer,
	student_name		varchar,
	theme_name			varchar,
	main_teacher_id		integer,
	econ_teacher_id		integer,
	safe_teacher_id		integer
)
AS $$
BEGIN
	RETURN QUERY
	SELECT 
		themes.theme_id, themes.student_id, students.student_name, themes.theme_name, 
		themes.main_teacher_id, themes.econ_teacher_id, themes.safe_teacher_id
	FROM themes 
	JOIN students USING (student_id);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION get_stage_names ()
RETURNS TABLE (
	stage_name_id		integer,
	stage_name			varchar
)
AS $$
BEGIN
	RETURN QUERY
	SELECT stage_names.stage_name_id, stage_names.stage_name
	FROM stage_names;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION get_stages ()
RETURNS TABLE (
	stage_id			integer,
	stage_name_id		integer,
	stage_name			varchar,
	theme_id			integer,
	teacher_id			integer,
	teacher_name		varchar,
	percentage			integer,
	date_started		date,
	date_ended			date
)
AS $$
BEGIN
	RETURN QUERY
	SELECT 
		stages.stage_id, stages.stage_name_id, stage_names.stage_name,
		stages.theme_id, stages.teacher_id, teachers.teacher_name, 
		stages.percentage, stages.date_started, stages.date_ended
	FROM stages
	JOIN stage_names USING (stage_name_id)
	JOIN teachers USING (teacher_id);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION check_password (_user_id integer, _pass varchar(128))
RETURNS integer
AS $$
DECLARE
	_pass_hash varchar(60);
BEGIN
	-- CODES:
	-- 0 - success
	-- 1 - fail

	_pass_hash = (SELECT pass_hash FROM users WHERE users.user_id = _user_id);

	IF crypt(_pass, _pass_hash) = _pass_hash THEN
		RETURN 0;
	ELSE 
		RETURN 1;
	END IF;
END;
$$ LANGUAGE 'plpgsql';