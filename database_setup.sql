CREATE TABLE IF NOT EXISTS transaksi (
    id_transaksi INT AUTO_INCREMENT PRIMARY KEY,
    id_user INT NOT NULL,
    id_player VARCHAR(50) NOT NULL,
    server_id VARCHAR(50),
    item VARCHAR(100) NOT NULL,
    harga INT NOT NULL,
    tanggal DATETIME NOT NULL,
    status VARCHAR(50) NOT NULL,
    game VARCHAR(50) NOT NULL,
    FOREIGN KEY (id_user) REFERENCES users(id_user)
);
