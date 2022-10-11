create database school
use school

create table student(
student_id numeric(5) primary key,
student_name varchar(20),
student_address varchar(100),
student_email varchar(75),
student_class varchar(5) 

)

create table subject(
subject_id numeric(5) primary key,
subject_name varchar(5)
)

create table class(
class_id numeric(5),
class_name varchar(20)
)