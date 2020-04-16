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

insert into customer(cpf, name, phone, birthdate, email, address1, address2) values ("12345678970, "Tubos", "12345678", 02/05/1999, "t_ubos@gmail.com", "Rua Francisca 103", "Jardim da Silva")
insert into customer(cpf, name, phone, birthdate, email, address1, address2) values ("07987654321, "Dyumikya", "87654321", 05/06/1998, "d_yumikya@gmail.com", "Rua Hernandez 505", "Jardim da Rocha")
insert into customer(cpf, name, phone, birthdate, email, address1, address2) values ("01987654321, "Usper", "98765432", 12/07/1997, "u_sper@gmail.com", "Rua José Bonifácio 901", "Jardim de Oliveira")
insert into customer(cpf, name, phone, birthdate, email, address1, address2) values ("09875482315, "Nauvo", "10987654", 12/08/1996, "n_auvo@gmail.com", "Rua Osvaldo Luis 102", "Jardim São José")
insert into customer(cpf, name, phone, birthdate, email, address1, address2) values ("58421586178, "Dimuol", "78452136", 04/09/1995, "d_imuol@gmail.com", "Rua Teixeira Nogueira 355", "Jardim Esmeralda")
insert into customer(cpf, name, phone, birthdate, email, address1, address2) values ("15456483489, "Luiral", "45612378", 07/10/1994, "l_uiral@gmail.com", "Rua Carlos da Silva 412", "Jardim Ametista")
insert into customer(cpf, name, phone, birthdate, email, address1, address2) values ("48734687548, "Runas", "25814736", 05/11/1993, "r_unas@gmail.com", "Rua Roberto Augusto 782", "Jardim das Nuvens")
insert into customer(cpf, name, phone, birthdate, email, address1, address2) values ("78784542486, "Xaula", "96325874", 03/12/1992, "x_aula@gmail.com", "Rua Sorveteiro 202", "Jardim da Avenida")

create table product(
id integer primary key,
name varchar(50),
sellPrice decimal(10),
company varchar(50),
quantity decimal(10),
category varchar(50),
buyPrice decimal(10)
);

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
productId integer,
foreign key (productId) references product(id)
);

insert into service(description, price) values ("Formatação de Sistema", 70.00)
insert into service(description, price) values ("Limpeza de Computadores", 40.00)
insert into service(description, price) values ("Montagem de Computadores", 80.00)
insert into service(description, price) values ("Troca de Componentes", 90.00)
insert into service(description, price) values ("Criação de Sites", 3000.00)
insert into service(description, price) values ("Criação de Aplicativos Android/IOS", 12000.00)
insert into service(description, price) values ("Criação de Aplicativos Desktop", 4000.00)
insert into service(description, price) values ("Design de Banners", 150.00)
insert into service(description, price) values ("Design de Logos", 75.00)

create table sale (
id integer primary key,
payment varchar(25),
price decimal,
serviceId integer,
clientId integer,
foreign key (serviceId) references service(id),
foreign key (clientId) references customer(id)
);

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

create table users (
id integer primary key,
name varchar(50),
email varchar(35),
password varchar(15)
);

insert into users(name, email, password) values ("Alexandra Rudolf", "a_rudolf@softti.com", "123456A@")
insert into users(name, email, password) values ("Matheus Sales", "m_sales@softti.com", "freelaN!ce")
insert into users(name, email, password) values ("Thales Zago", "t_zago@softti.com", "Bozon4ro!")
insert into users(name, email, password) values ("Thiago Santos", "t_costa@softti.com", "J4vaMelhor!")
insert into users(name, email, password) values ("Thomas Domingos", "t_domingos@softti.com", "123D!")
insert into users(name, email, password) values ("Roberta Sorros", "r_sorros@softti.com", "RS0rr!")
insert into users(name, email, password) values ("Thifanny Costa", "t_Costa@softti.com", "Ch0col4te!")
insert into users(name, email, password) values ("Juliana Gonçalves", "j_goncalves@softti.com", "Butt3rfly!")

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
