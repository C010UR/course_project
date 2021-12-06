SELECT add_teacher_type ('teacher type 1');
SELECT add_teacher_type ('teacher type 2');
SELECT add_teacher_type ('teacher type 3');
SELECT add_teacher_type ('teacher type 4');

SELECT update_teacher_type (1, 'teacher type 10');

SELECT delete_teacher_type (4);

SELECT * FROM get_teacher_types();

------------------------------------------------

SELECT add_teacher (1, 'teacher 1', 'address 1', 'phone 1', '123');
SELECT add_teacher (2, 'teacher 2', 'address 2', 'phone 2', '123');
SELECT add_teacher (3, 'teacher 3', 'address 3', 'phone 3', '123');
SELECT add_teacher (1, 'teacher 4', 'address 4', 'phone 4', '123');

SELECT update_teacher (1, 2, 'teacher 10', 'address 10', 'phone 10', '12345');

SELECT delete_teacher (4);

SELECT * FROM get_teachers();

------------------------------------------------

SELECT add_group (1, 'group 1', 2021);
SELECT add_group (2, 'group 2', 2022);
SELECT add_group (3, 'group 3', 2023);
SELECT add_group (1, 'group 4', 2024);

SELECT update_group (1, 2, 'group 10', 2000);

SELECT delete_group (4);

SELECT * FROM get_groups();

------------------------------------------------

SELECT add_student (1, 'student 1', 'phone 1', '123');
SELECT add_student (2, 'student 2', 'phone 2', '123');
SELECT add_student (3, 'student 3', 'phone 3', '123');
SELECT add_student (1, 'student 4', 'phone 4', '123');

SELECT update_student (1, 2, 'student 10', 'phone 10', '12345');

SELECT delete_student (4);

SELECT * FROM get_students();

------------------------------------------------

SELECT add_theme (1, 'theme 1', 1, 1, 1);
SELECT add_theme (2, 'theme 2', 2, 2, 2);
SELECT add_theme (3, 'theme 3', 3, 3, 3);
SELECT add_theme (1, 'theme 4', 3, 2, 1);

SELECT update_theme (1, 2, 'theme 10', 2, 3, 2);

SELECT delete_theme (4);

SELECT * FROM get_themes();

------------------------------------------------

SELECT add_stage_name ('stage name 1');
SELECT add_stage_name ('stage name 2');
SELECT add_stage_name ('stage name 3');
SELECT add_stage_name ('stage name 4');

SELECT update_stage_name (1, 'stage name 10');

SELECT delete_stage_name (4);

SELECT * FROM get_stage_names();

------------------------------------------------

SELECT add_stage (1, 1, 1, 0 , '2021-01-01', '2021-01-01');
SELECT add_stage (2, 2, 2, 25, '2021-02-02', '2021-02-02');
SELECT add_stage (3, 3, 3, 50, '2021-03-03', '2021-03-03');
SELECT add_stage (1, 1, 1, 75, '2021-04-04', '2021-04-04');

SELECT update_Stage (1, 3, 3, 3, 100, '2020-05-05', '2020-05-05');

SELECT delete_stage (4);

SELECT * FROM get_stages();

------------------------------------------------

SELECT * FROM get_users(); 

SELECT check_password (1, '12345');
SELECT check_password (2, '123');
SELECT check_password (3, '421');