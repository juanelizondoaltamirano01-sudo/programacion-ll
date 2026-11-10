CREATE TABLE Pedidos (
    IdPedido INT AUTO_INCREMENT PRIMARY KEY,
    IdCliente INT NOT NULL,
    Fecha DATE NOT NULL,
    Total DECIMAL(10,2),
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente)
);