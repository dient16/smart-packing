CREATE DATABASE SmartParking
go
Use SmartParking
go
CREATE TABLE Role (
  RoleID INT NOT NULL PRIMARY KEY,
  RoleName VARCHAR(50) NOT NULL
);
CREATE TABLE Users (
  UserID INT NOT NULL PRIMARY KEY,
  Username VARCHAR(50) NOT NULL,
  DisplayName NVARCHAR(255) NOT NULL,
  Password VARCHAR(50) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  RoleID INT NOT NULL,
  FOREIGN KEY (RoleID) REFERENCES Role(RoleID)
);

CREATE TABLE Car (
  CarID INT NOT NULL PRIMARY KEY,
  CarType VARCHAR(50) NOT NULL,
  CarName VARCHAR(50) NOT NULL,
  LicensePlate VARCHAR(20) NOT NULL
);

CREATE TABLE ParkingSpace (
  SpaceID INT NOT NULL PRIMARY KEY,
  SpaceNumber VARCHAR(20) NOT NULL,
  Availability NVARCHAR(100) NOT NULL
);

CREATE TABLE Booking (
  BookingID INT NOT NULL PRIMARY KEY,
  UserID INT NULL,
  SpaceID INT NOT NULL,
  BookingTime DATETIME NOT NULL,
  EmailGust VARCHAR(50) NULL,
  Status NVARCHAR(100) NOT NULL,
  FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE SET NULL,
  FOREIGN KEY (SpaceID) REFERENCES ParkingSpace(SpaceID)
);

CREATE TABLE CheckInOut (
  CheckInOutID INT NOT NULL PRIMARY KEY,
  CarID INT NOT NULL,
  SpaceID INT NOT NULL,
  BookingID INT NULL,
  CheckInTime DATETIME,
  CheckOutTime DATETIME ,
  TotalCost FLOAT NOT NULL,
  Status NVARCHAR(100) NOT NULL,
  FOREIGN KEY (CarID) REFERENCES Car(CarID),
  FOREIGN KEY (SpaceID) REFERENCES ParkingSpace(SpaceID),
  FOREIGN KEY (BookingID) REFERENCES Booking(BookingID) ON DELETE SET NULL
);

--Insert data
-------------------
INSERT INTO Role(RoleID, RoleName) VALUES
(1, 'admin'),
(2, 'employee'),
(3, 'user');

INSERT INTO Users (UserID, Username, DisplayName, Password, Email, RoleID)
VALUES 
(1, 'admin', N'Nguyễn Văn Anh', '7d6ca0e47676cc0b934d06402a56e2c0', 'nguyenvana@gmail.com', 1),
(2, 'employee1', N'Trần Thị Bình', '6fd742a61bd034804c00c49b18045020', 'tranthib@gmail.com', 2),
(3, 'employee2', N'Lê Thị Cúc', '6fd742a61bd034804c00c49b18045020', 'lethic@gmail.com', 2),
(4, 'user1', N'Phạm Thụy Đào', '6fd742a61bd034804c00c49b18045020', 'phamthud@gmail.com', 3),
(5, 'dinhvietE', N'Đinh Việt Anh', '6fd742a61bd034804c00c49b18045020', 'dinhviete@gmail.com', 3),
(6, 'nguyenthuyF', N'Nguyễn Thuỳ Fanny', '6fd742a61bd034804c00c49b18045020', 'nguyenthuyf@gmail.com', 3),
(7, 'hoangtuanG', N'Hoàng Tuấn Giang', '6fd742a61bd034804c00c49b18045020', 'hoangtuang@gmail.com', 3);


INSERT INTO ParkingSpace (SpaceID, SpaceNumber, Availability) VALUES
(1, '1A', N'Trống'),
(2, '2A', N'Trống'),
(3, '3A', N'Trống'),
(4, '4A', N'Trống'),
(5, '5A', N'Trống'),
(6, '6A', N'Trống'),
(7, '7A', N'Trống'),
(8, '8A', N'Trống'),
(9, '9A', N'Trống'),
(10, '10A', N'Trống'),
(11, '11A', N'Trống'),
(12, '12A', N'Trống'),
(13, '13A', N'Trống'),
(14, '14A', N'Trống'),
(15, '15A', N'Trống'),
(16, '16A', N'Trống'),
(17, '17A', N'Trống'),
(18, '18A', N'Trống'),
(19, '19A', N'Trống'),
(20, '20A', N'Trống'),
(21, '1B', N'Trống'),
(22, '2B', N'Trống'),
(23, '3B', N'Trống'),
(24, '4B', N'Trống'),
(25, '5B', N'Trống'),
(26, '6B', N'Trống'),
(27, '7B', N'Trống'),
(28, '8B', N'Trống'),
(29, '9B', N'Trống'),
(30, '10B', N'Trống'),
(31, '11B', N'Trống'),
(32, '12B', N'Trống'),
(33, '13B', N'Trống'),
(34, '14B', N'Trống'),
(35, '15B', N'Trống'),
(36, '16B', N'Trống'),
(37, '17B', N'Trống'),
(38, '18B', N'Trống'),
(39, '19B', N'Trống'),
(40, '20B', N'Trống'),
(41, '1C', N'Trống'),
(42, '2C', N'Trống'),
(43, '3C', N'Trống'),
(44, '4C', N'Trống'),
(45, '5C', N'Trống'),
(46, '6C', N'Trống'),
(47, '7C', N'Trống'),
(48, '8C', N'Trống'),
(49, '9C', N'Trống'),
(50, '10C', N'Trống'),
(51, '11C', N'Trống'),
(52, '12C', N'Trống'),
(53, '13C', N'Trống'),
(54, '14C', N'Trống');


INSERT INTO CAR (CARID, CARTYPE, CARNAME, LICENSEPLATE) VALUES
(1, 'OT', N'Ô TÔ', '25H1-23456'),
(2, 'OT', N'Ô TÔ', '29H1-12345'),
(3, 'OT', N'Ô TÔ', '51G1-56789'),
(4, 'OT', N'Ô TÔ', '36H3-67890'),
(5, 'OT', N'Ô TÔ', '87G2-12345'),
(6, 'XM', N'XE MÁY', '99H1-45678'),
(7, 'OT', N'Ô TÔ', '79G1-34567');


INSERT INTO Booking (BookingID, UserID, SpaceID, BookingTime, Status) VALUES
(1, 1, 1, '2023-03-29 09:00:00', N'Đã đặt'),
(2, 2, 2, '2023-03-29 10:00:00', N'Đã đặt'),
(3, 3, 3, '2023-03-29 11:00:00', N'Đã đặt'),
(4, 1, 4, '2023-03-29 12:00:00', N'Đã đặt'),
(5, 4, 5, '2023-03-29 13:00:00', N'Đã đặt'),
(6, 5, 6, '2023-03-29 14:00:00', N'Đã đặt'),
(7, 6, 7, '2023-03-29 15:00:00', N'Đã đặt');

INSERT INTO CheckInOut (CheckInOutID, CarID, SpaceID, CheckInTime, CheckOutTime, TotalCost, Status) VALUES
(1, 1, 1, '2023-03-29 09:10:00', '2023-03-29 11:10:00', 50000, N'Đang đỗ xe'),
(2, 2, 2, '2023-03-29 10:20:00', '2023-03-29 12:20:00', 50000, N'Đang đỗ xe'),
(3, 3, 3, '2023-03-29 11:30:00', '2023-03-29 13:30:00', 50000, N'Đang đỗ xe')