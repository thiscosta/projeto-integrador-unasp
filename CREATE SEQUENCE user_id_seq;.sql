CREATE SEQUENCE user_id_seq;
ALTER TABLE users ALTER id SET DEFAULT NEXTVAL('user_id_seq');

CREATE SEQUENCE service_id_seq;
ALTER TABLE service ALTER id SET DEFAULT NEXTVAL('service_id_seq');

CREATE SEQUENCE saleitem_id_seq;
ALTER TABLE saleitem ALTER id SET DEFAULT NEXTVAL('saleitem_id_seq');