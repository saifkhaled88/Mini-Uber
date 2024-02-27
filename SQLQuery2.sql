create table cities(
city_id int primary key,
city_name varchar(50) unique not null);


create table destination(
from_id int foreign key references cities(city_id),
to_id int foreign key references cities(city_id),
cost float not null);
