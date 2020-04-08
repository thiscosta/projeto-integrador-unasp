create table saleitem(
id integer primary key,
serviceId integer,
productId integer
)

create table product(
id integer primary key,
name varchar(50),
sellPrice decimal(10),
company varchar(50),
quantity decimal(10),
category varchar(50),
buyPrice decimal(10)
)

create table service (
id integer primary key,
description varchar(50),
price decimal(10)
)

/* chave estrangeira referenciando o id do servico dentro da tabela compra*/
create table sale (
id integer primary key,
payment varchar(25),
price decimal,
customerId integer,
foreign key (customerId) references customer(id)
)

create table users (
id integer primary key,
name varchar(50),
email varchar(35),
password varchar(15)
)

/* chave estrangeira referenciando o id da compra dentro da tabela parcela*/
create table parcel (
id integer primary key,
price decimal(10),
dueDate date,
saleId integer,
foreign key(saleId ) references sale (id)
)

create table customer(
id integer primary key,
cpf varchar(10),
name varchar(50),
contact varchar(50),
birthdate date,
email varchar(35)
)

/* chave estrangeira referenciando o id do cliente dentro da tabela endereco*/
create table address (
id integer primary key,
cep varchar(10),
city varchar(25),
state varchar(25),
street varchar(50),
customerId integer,
foreign key(customerId) references customer (id)
)

/* chave estrangeira referenciando o id do serviço dentro da tabela itemservico*/
alter table saleItem add foreign key(serviceId) references service (id);

/* chave estrangeira referenciando o id do produto dentro da tabela itemservico*/
alter table saleItem add foreign key(productId) references product (id);

/* chave estrangeira referenciando o id do cliente dentro da tabela compra*/
alter table sale add foreign key(customerId) references customer (id);

CREATE SEQUENCE user_id_seq;
ALTER TABLE users ALTER id SET DEFAULT NEXTVAL('user_id_seq');

CREATE SEQUENCE service_id_seq;
ALTER TABLE service ALTER id SET DEFAULT NEXTVAL('service_id_seq');

CREATE SEQUENCE saleitem_id_seq;
ALTER TABLE saleItem ALTER id SET DEFAULT NEXTVAL('saleitem_id_seq');

CREATE SEQUENCE sale_id_seq;
ALTER TABLE sale ALTER id SET DEFAULT NEXTVAL('sale_id_seq');

CREATE SEQUENCE product_id_seq;
ALTER TABLE product ALTER id SET DEFAULT NEXTVAL('product_id_seq');

CREATE SEQUENCE parcel_id_seq;
ALTER TABLE parcel ALTER id SET DEFAULT NEXTVAL('parcel_id_seq');

CREATE SEQUENCE customer_id_seq;
ALTER TABLE customer ALTER id SET DEFAULT NEXTVAL('customer_id_seq');

CREATE SEQUENCE address_id_seq;
ALTER TABLE address ALTER id SET DEFAULT NEXTVAL('address_id_seq');
