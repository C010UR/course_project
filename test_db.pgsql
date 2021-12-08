SELECT add_teacher_type ('teacher type 4');

SELECT update_teacher_type ((SELECT MAX(teacher_types.type_id) FROM teacher_types), 'teacher type 5');

SELECT delete_teacher_type ((SELECT MAX(teacher_types.type_id) FROM teacher_types));

SELECT * FROM get_teacher_types();

------------------------------------------------

SELECT add_teacher (1, 'Байков Ипатий Ярославович', '171623, г. Воскресенское, ул. Марата, дом 40, квартира 499', '+7 (978) 781-01-63', '123');
SELECT add_teacher (2, 'Волкова Ульяна Кирилловна', '391492, г. Прибрежное, ул. Сельский пер, дом 117, квартира 891', '+7 (984) 539-62-71', '123');
SELECT add_teacher (3, 'Поднебесный Кузьма Вячеславович', '393424, г. Бокситогорск, ул. Автозаводский 1-й проезд, дом 149, квартира 494', '+7 (977) 040-16-12', '123');
SELECT add_teacher (1, 'teacher 4', 'address 4', 'phone 4', '123');

SELECT update_teacher ((SELECT MAX(teachers.teacher_id) FROM teachers), 2, 'teacher 5', 'address 5', 'phone 5', '12345');

SELECT delete_teacher ((SELECT MAX(teachers.teacher_id) FROM teachers));

SELECT * FROM get_teachers();

------------------------------------------------

SELECT add_group (1, 'СП-405', 2018);
SELECT add_group (2, 'СП-305', 2019);
SELECT add_group (3, 'ПО-309', 2020);
SELECT add_group (1, 'ПО-209', 2021);

SELECT update_group ((SELECT MAX(_groups.group_id) FROM _groups), 2, 'group 10', 2000);

SELECT delete_group ((SELECT MAX(_groups.group_id) FROM _groups));

SELECT * FROM get_groups();

------------------------------------------------

SELECT add_student (1, 'Стручкова Наталия Олеговна', '+7 (963) 475-94-41', '123');
SELECT add_student (2, 'Громова Розалия Владиславовна', '+7 (956) 881-87-34', '123');
SELECT add_student (3, 'Головин Бруно Ильич', '+7 (997) 315-01-83', '123');
SELECT add_student (1, 'student 4', 'phone 4', '123');

SELECT update_student ((SELECT MAX(students.student_id) FROM students), 2, 'student 5', 'phone 5', '12345');

SELECT delete_student ((SELECT MAX(students.student_id) FROM students));

SELECT * FROM get_students();

------------------------------------------------

SELECT add_theme (1, 'Автоматизация учета потока товаров', 1, 2, 3);
SELECT add_theme (2, 'Обработка входящей документации', 1, 2, 3);
SELECT add_theme (3, 'Автоматизация оценки дипломных проектов', 1, 2, 3);
SELECT add_theme (1, 'theme 4', 1, 2, 3);

SELECT update_theme ((SELECT MAX(themes.theme_id) FROM themes), 2, 'theme 10', 2, 3, 2);

SELECT delete_theme ((SELECT MAX(themes.theme_id) FROM themes));

SELECT * FROM get_themes();

------------------------------------------------

SELECT add_stage_name ('stage name 8');

SELECT update_stage_name ((SELECT MAX(stage_names.stage_name_id) FROM stage_names), 'stage name 9');

SELECT delete_stage_name ((SELECT MAX(stage_names.stage_name_id) FROM stage_names));

SELECT * FROM get_stage_names();

------------------------------------------------

SELECT add_stage (1, 1, 1, 75, '2021-04-04', '2021-04-04');

SELECT update_Stage ((SELECT MAX(stages.stage_id) FROM stages), 3, 3, 3, 100, '2020-05-05', '2020-05-05');

SELECT delete_stage ((SELECT MAX(stages.stage_id) FROM stages));

SELECT * FROM get_stages();

------------------------------------------------

SELECT * FROM get_users(); 

SELECT check_password (1, '12345');
SELECT check_password (2, '123');
SELECT check_password (3, '421');