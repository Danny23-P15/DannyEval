CREATE DATABASE gasimmo;
\c gasimmo;

CREATE SEQUENCE administrateur_seq;
CREATE TABLE IF NOT EXISTS administrateur(
    id VARCHAR PRIMARY KEY DEFAULT CONCAT('ADM', LPAD(nextval('administrateur_seq')::TEXT, 2, '0')),
    nom VARCHAR NOT NULL,
    email VARCHAR UNIQUE NOT NULL,
    mot_de_passe VARCHAR NOT NULL
);

CREATE SEQUENCE proprietaire_seq;
CREATE TABLE IF NOT EXISTS proprietaire(
    id VARCHAR PRIMARY KEY DEFAULT CONCAT('PROP', LPAD(nextval('proprietaire_seq')::TEXT, 2, '0')),
    nom VARCHAR NOT NULL,
    numero VARCHAR NOT NULL
);

CREATE SEQUENCE client_seq;
CREATE TABLE IF NOT EXISTS client(
    id VARCHAR PRIMARY KEY DEFAULT CONCAT('CLIENT', LPAD(nextval('client_seq')::TEXT, 2, '0')),
    nom VARCHAR NOT NULL,
    email VARCHAR UNIQUE NOT NULL
);


CREATE SEQUENCE tybe_bien_seq;
CREATE TABLE IF NOT EXISTS type_bien(
    id VARCHAR PRIMARY KEY DEFAULT CONCAT('TYPE_BIEN' LPAD(nextval('type_bien_seq')::TEXT, 2, '0')),
    nom VARCHAR NOT NULL
)

CREATE SEQUENCE bien_seq;
CREATE TABLE IF NOT EXISTS bien(
    id VARCHAR PRIMARY KEY DEFAULT CONCAT('BIEN', LPAD(nextval('bien_seq')::TEXT, 2, '0')),
    nom VARCHAR NOT NULL,
    description VARCHAR,
    region VARCHAR NOT NULL,
    loyer DECIMAL NOT NULL,
    photo_url TEXT NOT NULL,
    id_type_bien VARCHAR NOT NULL REFERENCES tybe_bien(id),
    id_proprietaire VARCHAR NOT NULL REFERENCES proprietaire(id)
);

CREATE TABLE IF NOT EXISTS location(
    id VARCHAR PRIMARY KEY DEFAULT CONCAT('LO')
);

INSERT INTO administrateur(nom, email, mot_de_passe) VALUES ('ADMIN', 'admin@gmail.com', '12345');

INSERT INTO proprietaire(nom, numero) VALUES ('prop1', '031');
INSERT INTO proprietaire(nom, numero) VALUES ('prop2', '032');
INSERT INTO proprietaire(nom, numero) VALUES ('prop3', '033');
INSERT INTO proprietaire(nom, numero) VALUES ('prop4', '034');

INSERT INTO client (nom, email) VALUES ('client1','client1@gmail.com');
INSERT INTO client (nom, email) VALUES ('client2','client2@gmail.com');
INSERT INTO client (nom, email) VALUES ('client3','client3@gmail.com');

