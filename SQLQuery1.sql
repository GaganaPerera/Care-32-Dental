CREATE TABLE PatientCases (
    CaseID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT ,
    TreatmentID INT ,
    DoctorID INT ,
    CustomAmount DECIMAL(10,2),
    Notes VARCHAR(255),
    CaseDate DATETIME DEFAULT GETDATE()
);

