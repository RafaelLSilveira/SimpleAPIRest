-- sqlcmd -S DESKTOP-TTJ5505\SQLEXPRESS -E
CREATE TABLE clients (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    tx_id VARCHAR (14) NOT NULL,
    identity_card VARCHAR (30) DEFAULT NULL,
    name VARCHAR (255) NOT NULL,
    phone VARCHAR (30) DEFAULT NULL,
    email VARCHAR(255),
    birth_date DATETIME NOT NULL,
    created DATETIME NOT NULL
);

-- Initial DATA
INSERT INTO clients (tx_id, identity_card, name, phone, email, birth_date, created)
VALUES ('76017535064', '123', 'João', '123', 'joao@email.com', '1992-10-02', GETDATE());

INSERT INTO clients (tx_id, identity_card, name, phone, email, birth_date, created)
VALUES ('09538576039', '1234', 'Pedro', '1234', 'pedro@email.com', '1993-08-10', GETDATE());