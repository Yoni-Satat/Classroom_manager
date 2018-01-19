# Classroom Manager: Week 16 CodeClan Project

## Classroom Manager

### Objectives:
- Practise class modelling in C# / .Net
- Practise OOP, TDD and GitHub collaboration
- Practise APIs

## Edinburgh University teacher requires an app to manage courses, classrooms and students.

### MVP user should be able to:
- Create courses and classrooms
- A course should be able to have multiple classes (groups of students), course name, course ID, course   level, no. of lessons
- A class should be able to have many students
- A course should be a collection of lessons
- A lesson should have a date, start and end time, mark mandatory yes/no, and should be numbered incrementally, should have a location (building and room number)
- A student should have: name and surname, id (matriculation number), gender, DOB, year of study, photo, adjustments (y/n), type (UK/ EU-EEA/overseas)
- Track students’ lesson attendance and absence reasons: sickness, personal reasons, exempt, other

### Possible extensions:
- The app should flag up absences as follows:
  - Flag first absence if lesson is mandatory
  - Flag on the third absence whether mandatory or optional
- The app should be able to create different size of smaller random groups within each class. The teacher needs to be able to define the number of students required in each group (eg: 2 students, 3-5 students).
- The app should be able to calculate:
  - % of absences by reasons (per course)
  - % of student absences by gender (per course)
  - % of absences per course by class
