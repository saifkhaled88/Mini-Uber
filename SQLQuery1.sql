CREATE TABLE client(
user_name varchar(50) primary key,
password varchar(50) not null,
phone_number varchar(50) not null,
credit_card_number varchar(50),
cvv varchar(50),
dob date);

CREATE TABLE vehicle(
plate_number varchar(50) primary key,
model varchar(50) not null,
v_type varchar(50) not null,
);

CREATE TABLE driver(
ssn varchar(50) primary key,
f_name varchar(50) not null,
l_name varchar(50) not null,
phone_number varchar(50),
plate_number varchar(50) foreign key references vehicle(plate_number));

CREATE TABLE ride(
ride_id int primary key,
price float not null,
d_from varchar(50) not null,
d_to varchar(50),
user_name varchar(50) foreign key references client(user_name),
driver_ssn varchar(50) foreign key references driver(ssn));

CREATE TABLE customer_care(
ticket_id int primary key,
ticket_type varchar(50)not null,
status varchar(50) not null,
problem_def varchar(50),
user_name varchar(50) foreign key references client(user_name),
driver_ssn varchar(50) foreign key references driver(ssn));

alter table client
add f_name varchar(50)

alter table client
add l_name varchar(50)

            