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
  Availability VARCHAR(20) NOT NULL
);

CREATE TABLE Booking (
  BookingID INT NOT NULL PRIMARY KEY,
  UserID INT default 0,
  SpaceID INT NOT NULL,
  BookingTime DATETIME NOT NULL,
  EmailGust VARCHAR(50),
  Status VARCHAR(50) NOT NULL,
  FOREIGN KEY (UserID) REFERENCES Users(UserID),
  FOREIGN KEY (SpaceID) REFERENCES ParkingSpace(SpaceID)
);

CREATE TABLE CheckInOut (
  CheckInOutID INT NOT NULL PRIMARY KEY,
  CarID INT NOT NULL,
  SpaceID INT NOT NULL,
  CheckInTime DATETIME NOT NULL,
  CheckOutTime DATETIME ,
  TotalCost DECIMAL(10, 2) NOT NULL,
  Status VARCHAR(50) NOT NULL,
  FOREIGN KEY (CarID) REFERENCES Car(CarID),
  FOREIGN KEY (SpaceID) REFERENCES ParkingSpace(SpaceID)
);


--Insert data
-------------------
INSERT INTO Role(RoleID, RoleName) VALUES
(1, 'admin'),
(2, 'employee'),
(3, 'user'),
(4, 'guest');

INSERT INTO Users (UserID, Username, Password, Email, RoleId) VALUES
(0, 'guest', 'fdfe55b8a68ffb068d3f3c2649ab542a', 'guest@gmail.com', 4),
(1, 'user1', '6fd742a61bd034804c00c49b18045020', 'user1@gmail.com', 3),
(2, 'user2', '6fd742a61bd034804c00c49b18045020', 'user2@gmail.com', 3),
(3, 'admin', '7d6ca0e47676cc0b934d06402a56e2c0', 'admin@gmail.com', 1),
(4, 'employee1', '5874c47d252c82ee040126747cff6a9f', 'employee1@gmail.com', 2),
(5, 'employee2', '5874c47d252c82ee040126747cff6a9f', 'employee2@gmail.com', 2),
(6, 'user3', '6fd742a61bd034804c00c49b18045020', 'user3@gmail.com', 3),
(7, 'user4', '6fd742a61bd034804c00c49b18045020', 'user4@gmail.com', 3);


INSERT INTO Car (CarID, CarType, CarName, LicensePlate) VALUES
(1, 'OT', 'Ô tô', '25H1-23456'),
(2, 'OT', 'Ô tô', '29H1-12345'),
(3, 'OT', 'Ô tô', '51G1-56789'),
(4, 'OT', 'Ô tô', '36H3-67890'),
(5, 'OT', 'Ô tô', '87G2-12345'),
(6, 'XM', 'Xe máy', '99H1-45678'),
(7, 'OT', 'Ô tô', '79G1-34567');

INSERT INTO ParkingSpace (SpaceID, SpaceNumber, Availability) VALUES
(1, '1A', 'Trống'),
(2, '2A', 'Trống'),
(3, '3A', 'Trống'),
(4, '4A', 'Trống'),
(5, '5A', 'Đã đặt'),
(6, '6A', 'Đã đỗ xe'),
(7, '7A', 'Trống');

INSERT INTO ParkingSpace (SpaceID, SpaceNumber, Availability) VALUES
(8, '8A', 'Trống'),
(9, '9A', 'Trống'),
(10, '10A', 'Trống'),
(11, '11A', 'Trống'),
(12, '12A', 'Trống'),
(13, '13A', 'Trống'),
(14, '14A', 'Trống'),
(15, '15A', 'Trống'),
(16, '16A', 'Trống'),
(17, '17A', 'Trống'),
(18, '18A', 'Trống'),
(19, '19A', 'Trống'),
(20, '20A', 'Trống'),
(21, '1B', 'Trống'),
(22, '2B', 'Trống'),
(23, '3B', 'Trống'),
(24, '4B', 'Trống'),
(25, '5B', 'Đã đặt'),
(26, '6B', 'Đã đỗ xe'),
(27, '7B', 'Trống'),
(28, '8B', 'Trống'),
(29, '9B', 'Trống'),
(30, '10B', 'Trống'),
(31, '11B', 'Trống'),
(32, '12B', 'Trống'),
(33, '13B', 'Trống'),
(34, '14B', 'Trống'),
(35, '15B', 'Trống'),
(36, '16B', 'Trống'),
(37, '17B', 'Trống'),
(38, '18B', 'Trống'),
(39, '19B', 'Trống'),
(40, '20B', 'Trống');

INSERT INTO Booking (BookingID, UserID, SpaceID, BookingTime, Status) VALUES
(1, 1, 1, '2023-03-29 09:00:00', 'Đã đặt'),
(2, 2, 2, '2023-03-29 10:00:00', 'Đã đặt'),
(3, 3, 3, '2023-03-29 11:00:00', 'Đã đặt'),
(4, 1, 4, '2023-03-29 12:00:00', 'Đã đặt'),
(5, 4, 5, '2023-03-29 13:00:00', 'Đã đặt'),
(6, 5, 6, '2023-03-29 14:00:00', 'Đã đặt'),
(7, 6, 7, '2023-03-29 15:00:00', 'Đã đặt');

INSERT INTO CheckInOut (CheckInOutID, CarID, SpaceID, CheckInTime, CheckOutTime, TotalCost, Status) VALUES
(1, 1, 1, '2023-03-29 09:10:00', '2023-03-29 11:10:00', 50000, 'Đã đỗ xe'),
(2, 2, 2, '2023-03-29 10:20:00', '2023-03-29 12:20:00', 50000, 'Đã đỗ xe'),
(3, 3, 3, '2023-03-29 11:30:00', '2023-03-29 13:30:00', 50000, 'Đã đỗ xe')