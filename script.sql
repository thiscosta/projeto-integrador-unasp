create table customer(
id integer primary key,
cpf varchar(10),
name varchar(50),
phone varchar(50),
birthdate date,
email varchar(35),
address1 varchar(255),
address2 varchar(255)
);

create table product(
id integer primary key,
name varchar(50),
sellPrice decimal(10),
company varchar(50),
quantity decimal(10),
category varchar(50),
buyPrice decimal(10)
);

create table service (
id integer primary key,
description varchar(50),
foreign key (productId) references product(id)
);

create table sale (
id integer primary key,
payment varchar(25),
price decimal,
serviceId integer,
foreign key (serviceId) references service(id)
);

create table users (
id integer primary key,
name varchar(50),
email varchar(35),
password varchar(15)
);


CREATE SEQUENCE user_id_seq;
ALTER TABLE users ALTER id SET DEFAULT NEXTVAL('user_id_seq');

CREATE SEQUENCE service_id_seq;
ALTER TABLE service ALTER id SET DEFAULT NEXTVAL('service_id_seq');

CREATE SEQUENCE sale_id_seq;
ALTER TABLE sale ALTER id SET DEFAULT NEXTVAL('sale_id_seq');

CREATE SEQUENCE product_id_seq;
ALTER TABLE product ALTER id SET DEFAULT NEXTVAL('product_id_seq');

CREATE SEQUENCE customer_id_seq;
ALTER TABLE customer ALTER id SET DEFAULT NEXTVAL('customer_id_seq');

INSERT INTO users(email, password) VALUES('admin', 'admin')
