CREATE DATABASE SmartParking
go
Use SmartParking
go
CREATE TABLE Role (
  RoleID INT NOT NULL PRIMARY KEY  IDENTITY(1,1),
  RoleName VARCHAR(50) NOT NULL
);
CREATE TABLE Users (
  UserID INT NOT NULL PRIMARY KEY  IDENTITY(1,1) ,
  Username VARCHAR(50) NOT NULL,
  DisplayName NVARCHAR(255) NOT NULL,
  Password VARCHAR(50) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  RoleID INT NOT NULL,
  FOREIGN KEY (RoleID) REFERENCES Role(RoleID)
);

CREATE TABLE Car (
  CarID INT NOT NULL PRIMARY KEY  IDENTITY(1,1) ,
  CarType VARCHAR(50) NOT NULL,
  CarName VARCHAR(50) NOT NULL,
  LicensePlate VARCHAR(20) NOT NULL
);

CREATE TABLE ParkingSpace (
  SpaceID INT NOT NULL PRIMARY KEY IDENTITY(1,1) ,
  SpaceNumber VARCHAR(20) NOT NULL,
  Availability NVARCHAR(100) NOT NULL
);

CREATE TABLE Booking (
  BookingID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  UserID INT NOT NULL,
  SpaceID INT NOT NULL,
  BookingTime DATETIME NOT NULL,
  CarID INT NOT NULL,
  Status NVARCHAR(100) NOT NULL,
  FOREIGN KEY (UserID) REFERENCES Users(UserID),
  FOREIGN KEY (SpaceID) REFERENCES ParkingSpace(SpaceID), 
  FOREIGN KEY (CarID) REFERENCES Car(CarID),
);

CREATE TABLE CheckInOut (
  CheckInOutID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
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
INSERT INTO Role(RoleName) VALUES
('admin'),
('employee'),
('user');

INSERT INTO Users (Username, DisplayName, Password, Email, RoleID)
VALUES 
('admin', N'Nguyễn Văn Anh', '6fd742a61bd034804c00c49b18045020', 'nguyenvana@gmail.com', 1),
('employee1', N'Trần Thị Bình', '6fd742a61bd034804c00c49b18045020', 'tranthib@gmail.com', 2),
('employee2', N'Lê Thị Cúc', '6fd742a61bd034804c00c49b18045020', 'lethic@gmail.com', 2),
('user1', N'Phạm Thụy Đào', '6fd742a61bd034804c00c49b18045020', 'phamthud@gmail.com', 3),
('dinhvietE', N'Đinh Việt Anh', '6fd742a61bd034804c00c49b18045020', 'dinhviete@gmail.com', 3),
('nguyenthuyF', N'Nguyễn Thuỳ Fanny', '6fd742a61bd034804c00c49b18045020', 'nguyenthuyf@gmail.com', 3),
('hoangtuanG', N'Hoàng Tuấn Giang', '6fd742a61bd034804c00c49b18045020', 'hoangtuang@gmail.com', 3);


INSERT INTO ParkingSpace (SpaceNumber, Availability) VALUES
('1A', N'Trống'),
('2A', N'Trống'),
('3A', N'Trống'),
('4A', N'Trống'),
('5A', N'Trống'),
('6A', N'Trống'),
('7A', N'Trống'),
('8A', N'Trống'),
('9A', N'Trống'),
('10A', N'Trống'),
('11A', N'Trống'),
('12A', N'Trống'),
('13A', N'Trống'),
('14A', N'Trống'),
('15A', N'Trống'),
('16A', N'Trống'),
('17A', N'Trống'),
('18A', N'Trống'),
('19A', N'Trống'),
('20A', N'Trống'),
('1B', N'Trống'),
('2B', N'Trống'),
('3B', N'Trống'),
('4B', N'Trống'),
('5B', N'Trống'),
('6B', N'Trống'),
('7B', N'Trống'),
('8B', N'Trống'),
('9B', N'Trống'),
('10B', N'Trống'),
('11B', N'Trống'),
('12B', N'Trống'),
('13B', N'Trống'),
('14B', N'Trống'),
('15B', N'Trống'),
('16B', N'Trống'),
('17B', N'Trống'),
('18B', N'Trống'),
('19B', N'Trống'),
('20B', N'Trống'),
('1C', N'Trống'),
('2C', N'Trống'),
('3C', N'Trống'),
('4C', N'Trống'),
('5C', N'Trống'),
('6C', N'Trống'),
('7C', N'Trống'),
('8C', N'Trống'),
('9C', N'Trống'),
('10C', N'Trống'),
('11C', N'Trống'),
('12C', N'Trống'),
('13C', N'Trống'),
('14C', N'Trống');


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

drop database SmartParking