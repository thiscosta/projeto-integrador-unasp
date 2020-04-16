create table sale_item(
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
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Hard Disk 1TB", 200.00, "Samsung", 205.00, "IT Tools", 99.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("RAM Memory 8GB DDR4", 299.00, "Crucial", 110.00, "IT Tools", 150.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Solid State Drive (SSD) 512GB", 456.00, "Kingston", 152.00, "IT Tools", 320.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Hard Disk 3TB", 551.00, "Seagate", 401.00, "IT Tools", 400.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Gamer Keyboard Fallen Ace Switch Red", 570.00, "Fallen Gear", 95.00, "IT Tools", 450.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Mouse Bungee Fallen Eco", 55.00, "Fallen Gear", 381.00, "IT Tools", 25.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Gamer Headset Fallen Morcego", 466.67, "Fallen Gear", 205.00, "IT Tools", 350.25)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Monitor Dell 24: SE2419HR", 909.00, "Dell", 80.00, "IT Tools", 740.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Monitor Dell Touch Screen de 24", 2120.00, "Dell", 73.00, "IT Tools", 1820.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Monitor Dell 24 Ultrasharp - U2415", 2168.00, "Dell", 35.00, "IT Tools", 1852.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Networking X1026", 3329.00, "Dell", 20.00, "IT Tools", 2800.00)
insert into product(name, sellPrice, company, quantity, category, buyPrice) values ("Mochila Dell Pro - 15,6 ", 239.00, "Dell", 451.00, "IT Tools", 150.00)

create table service (
id integer primary key,
description varchar(50),
price decimal(10)
)

insert into service(description, price) values ("Formatação de Sistema", 70.00)
insert into service(description, price) values ("Limpeza de Computadores", 40.00)
insert into service(description, price) values ("Montagem de Computadores", 80.00)
insert into service(description, price) values ("Troca de Componentes", 90.00)
insert into service(description, price) values ("Criação de Sites", 3000.00)
insert into service(description, price) values ("Criação de Aplicativos Android/IOS", 12000.00)
insert into service(description, price) values ("Criação de Aplicativos Desktop", 4000.00)
insert into service(description, price) values ("Design de Banners", 150.00)
insert into service(description, price) values ("Design de Logos", 75.00)

/* chave estrangeira referenciando o id do servico dentro da tabela compra*/
create table sale (
id integer primary key,
payment varchar(25),
price decimal(),
customerId integer,
foreign key (customerId) references customer(id)
)
insert into sale(payment, price) values ("Credit", 200.00)
insert into sale(payment, price) values ("Debit", 299.00)
insert into sale(payment, price) values ("Debit", 150.00)
insert into sale(payment, price) values ("Money", 40.00)
insert into sale(payment, price) values ("Credit", 3000.00)
insert into sale(payment, price) values ("Credit", 2168.00)
insert into sale(payment, price) values ("Credit", 570.00)
insert into sale(payment, price) values ("Debit", 75.00)
insert into sale(payment, price) values ("Debit", 90.00)
insert into sale(payment, price) values ("Money", 80.00)

create table user (
id integer primary key,
name varchar(50),
email varchar(35),
password varchar(15)
)

insert into user(name, email, password) values ("Alexandra Rudolf", "a_rudolf@softti.com", "123456A@")
insert into user(name, email, password) values ("Matheus Sales", "m_sales@softti.com", "freelaN!ce")
insert into user(name, email, password) values ("Thales Zago", "t_zago@softti.com", "Bozon4ro!")
insert into user(name, email, password) values ("Thiago Santos", "t_costa@softti.com", "J4vaMelhor!")
insert into user(name, email, password) values ("Thomas Domingos", "t_domingos@softti.com", "123D!")
insert into user(name, email, password) values ("Roberta Sorros", "r_sorros@softti.com", "RS0rr!")
insert into user(name, email, password) values ("Thifanny Costa", "t_Costa@softti.com", "Ch0col4te!")
insert into user(name, email, password) values ("Juliana Gonçalves", "j_goncalves@softti.com", "Butt3rfly!")

/* chave estrangeira referenciando o id da compra dentro da tabela parcela*/
create table parcel (
id integer primary key,
price decimal(10),
dueDate datetime,
saleId integer,
foreign key(saleId ) references sale (id)
)

insert into parcel(price, dueDate) values (22.00, 04/05/2020)
insert into parcel(price, dueDate) values (82.00, 08/03/2020)
insert into parcel(price, dueDate) values (102.00, 09/04/2020)
insert into parcel(price, dueDate) values (42.00, 12/05/2020)
insert into parcel(price, dueDate) values (56.00, 02/06/2020)
insert into parcel(price, dueDate) values (73.00, 03/07/2020)
insert into parcel(price, dueDate) values (90.00, 04/08/2020)

create table customer(
id integer primary key,
cpf varchar(10),
name varchar(50),
contact varchar(50),
birthdate datetime,
email varchar(35)
)

insert into customer(cpf, name, contact, birthdate) values ("12345678970, "Tubos", "12345678", 02/05/1999)
insert into customer(cpf, name, contact, birthdate) values ("07987654321, "Dyumikya", "87654321", 05/06/1998)
insert into customer(cpf, name, contact, birthdate) values ("01987654321, "Usper", "98765432", 12/07/1997)
insert into customer(cpf, name, contact, birthdate) values ("09875482315, "Nauvo", "10987654", 12/08/1996)
insert into customer(cpf, name, contact, birthdate) values ("58421586178, "Dimuol", "78452136", 04/09/1995)
insert into customer(cpf, name, contact, birthdate) values ("15456483489, "Luiral", "45612378", 07/10/1994)
insert into customer(cpf, name, contact, birthdate) values ("48734687548, "Runas", "25814736", 05/11/1993)
insert into customer(cpf, name, contact, birthdate) values ("78784542486, "Xaula", "96325874", 03/12/1992)

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

insert into address(cep, city, state, street) values ("12345678", "Hortolândia", "São Paulo", "Juscelino Augusto")
insert into address(cep, city, state, street) values ("78945612", "Campinas", "São Paulo", "Edimar Tavares")
insert into address(cep, city, state, street) values ("89745621", "Jundiaí", "São Paulo", "Tancredo Neves")
insert into address(cep, city, state, street) values ("45871554", "Paulínia", "São Paulo", "Ricardo Oliveira")
insert into address(cep, city, state, street) values ("25485849", "Cosmópolis", "São Paulo", "Argentina")
insert into address(cep, city, state, street) values ("25487952", "Casa Branca", "São Paulo", "Pérola")
insert into address(cep, city, state, street) values ("68788525", "Indaiatuba", "São Paulo", "Esmeralda")

/* chave estrangeira referenciando o id do serviço dentro da tabela itemservico*/
alter table saleItem add foreign key(serviceId) references service (id)

/* chave estrangeira referenciando o id do produto dentro da tabela itemservico*/
alter table saleItem add foreign key(productId) references product (id)

/* chave estrangeira referenciando o id do cliente dentro da tabela compra*/
alter table sale add foreign key(customerId) references customer (id)

CREATE SEQUENCE user_id_seq;
ALTER TABLE users ALTER id SET DEFAULT NEXTVAL('user_id_seq');

CREATE SEQUENCE service_id_seq;
ALTER TABLE service ALTER id SET DEFAULT NEXTVAL('service_id_seq');

CREATE SEQUENCE saleitem_id_seq;
ALTER TABLE saleitem ALTER id SET DEFAULT NEXTVAL('saleitem_id_seq');

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
