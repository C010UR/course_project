CREATE EXTENSION IF NOT EXISTS pgcrypto;

DROP TABLE IF EXISTS  stages, stage_names, themes, students, groups, teachers, teacher_types, users;

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

CREATE TABLE groups (
	group_id        integer GENERATED ALWAYS AS IDENTITY NOT NULL,
	teacher_id      integer NOT NULL,
	group_name      varchar(32) NOT NULL,
	year_started    integer NOT NULL
);

ALTER TABLE groups 
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
	ADD CONSTRAINT fk_students_groups_group_id FOREIGN KEY (group_id) REFERENCES groups;

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
	get_teacher_types, get_teachers, get_groups, get_students, get_users, get_themes, get_stage_names, get_stages;

CREATE FUNCTION add_teacher_type (_type_name varchar(128))
RETURNS void
AS $$
BEGIN
	INSERT INTO teacher_types (type_name)
	VALUES (_type_name);
END;
$$ LANGUAGE SQL;

CREATE FUNCTION update_teacher_type (_type_id integer, _type_name varchar(128)) 
RETURNS void
AS $$
BEGIN 
	UPDATE teacher_types 
	SET type_name = _type_name
	WHERE type_id = _type_id;
END;
$$ LANGUAGE SQL;

CREATE FUNCTION delete_teacher_type (_type_id integer)
RETURNS void
AS $$
BEGIN
	DELETE FROM teacher_types
	WHERE type_id = _type_id;
END;
$$ LANGUAGE SQL;
