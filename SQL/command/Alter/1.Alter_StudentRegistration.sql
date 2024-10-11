ALTER TABLE tbStudentRegistration
ADD ID int NOT NULL ;

ALTER TABLE tbStudentRegistration
ADD UNIQUE (ID);

ALTER TABLE tbStudentRegistration
ADD zipcode bigint;
