CREATE TABLE Khoa (
    IdKhoa INT PRIMARY KEY,
    TenKhoa VARCHAR(255)
);
CREATE TABLE Lop (
    IdLop INT PRIMARY KEY,
    TenLop VARCHAR(255),
    IdKhoa INT,
    FOREIGN KEY (IdKhoa) REFERENCES Khoa(IdKhoa)
);
CREATE TABLE Sv (
    IdSv INT PRIMARY KEY,
    TenSv VARCHAR(255),
    Tuoi INT,
    IdLop INT,
    FOREIGN KEY (IdLop) REFERENCES Lop(IdLop)
);
INSERT INTO Khoa (IdKhoa, TenKhoa) VALUES (1, 'Khoa CNTT');

INSERT INTO Khoa (IdKhoa, TenKhoa) VALUES (2, 'Khoa xay dung');


INSERT INTO Lop (IdLop, TenLop, IdKhoa) VALUES (1, '20t1', 1);
INSERT INTO Lop (IdLop, TenLop, IdKhoa) VALUES (2, '20t3', 2);

INSERT INTO Sv (IdSv, TenSv, Tuoi, IdLop) VALUES (1001, 'thang', 19, 1);

INSERT INTO Sv (IdSv, TenSv, Tuoi, IdLop) VALUES (1002, 'thu', 21, 1);

INSERT INTO Sv (IdSv, TenSv, Tuoi, IdLop) VALUES (2001, 'vu', 18, 2);

INSERT INTO Sv (IdSv, TenSv, Tuoi, IdLop) VALUES (2002, 'quan', 20, 1);
