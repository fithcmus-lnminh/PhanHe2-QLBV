CREATE OR REPLACE PROCEDURE  sp_THEMNHANVIEN(
    manv IN NHANVIEN.MANV%TYPE,
    hoten  IN NHANVIEN.HOTEN%TYPE,
    phai  IN NHANVIEN.PHAI%TYPE,
    ngaysinh  IN VARCHAR2,
    cmnd  IN NHANVIEN.CMND%TYPE,
    quequan  IN NHANVIEN.QUEQUAN%TYPE,
    sodt  IN NHANVIEN.SODT%TYPE,
    csyt  IN NHANVIEN.CSYT%TYPE,
    vaitro  IN NHANVIEN.VAITRO%TYPE,
    chuyenkhoa  IN NHANVIEN.CHUYENKHOA%TYPE)
AS
    strSQL VARCHAR2(200);
BEGIN
    INSERT INTO NHANVIEN ("MANV", "HOTEN", "PHAI","NGAYSINH","CMND","QUEQUAN", "SODT","CSYT", "VAITRO", "CHUYENKHOA") 
    VALUES (manv, hoten, phai,TO_DATE(ngaysinh,'yyyy-mm-dd'),CMND,quequan, sodt, csyt, vaitro, chuyenkhoa);
    strSQL :='CREATE USER "'||manv||'" IDENTIFIED BY "'||manv||'"';
    EXECUTE IMMEDIATE (strSQL);
    strSQL :='GRANT R_NHANVIEN TO "'||manv||'"';
    EXECUTE IMMEDIATE (strSQL);
    
    IF (vaitro = 'Thanh tra') THEN
        strSQL :='GRANT R_THANHTRA TO "'||manv||'"';
        EXECUTE IMMEDIATE (strSQL);
    ELSIF (vaitro ='Co so y te') THEN
        strSQL :='GRANT R_COSOYTE TO "'||manv||'"';
        EXECUTE IMMEDIATE (strSQL);
    ELSIF (vaitro ='Y si / Bac si') THEN
        strSQL :='GRANT R_YSI_BACSI TO "'||manv||'"';
        EXECUTE IMMEDIATE (strSQL);
    ELSIF (vaitro ='Nghien cuu') THEN
        strSQL :='GRANT R_NGHIENCUU TO "'||manv||'"';
        EXECUTE IMMEDIATE (strSQL);
    END IF;
END;



CREATE OR REPLACE PROCEDURE sp_THEMBENHNHAN(
    mabn BENHNHAN.MABN%TYPE,
    macsyt BENHNHAN.MACSYT%TYPE,
    tenbn BENHNHAN.TENBN%TYPE,
    cmnd BENHNHAN.CMND%TYPE,
    ngaysinh  VARCHAR2,
    sonha BENHNHAN.SONHA%TYPE,
    tenduong BENHNHAN.TENDUONG%TYPE,
    quanhuyen BENHNHAN.QUANHUYEN%TYPE,
    tinhtp BENHNHAN.TINHTP%TYPE,
    tiensubenh BENHNHAN.TIENSUBENH%TYPE,
    tiensubenhgd BENHNHAN.TIENSUBENHGD%TYPE,
    diungthuoc BENHNHAN.DIUNGTHUOC%TYPE)
AS
    strSQL VARCHAR2(200);
BEGIN
    INSERT INTO BENHNHAN ("MABN","MACSYT","TENBN","CMND","NGAYSINH","SONHA","TENDUONG","QUANHUYEN","TINHTP","TIENSUBENH","TIENSUBENHGD","DIUNGTHUOC")
    VALUES (mabn,macsyt,tenbn,CMND,TO_DATE(ngaysinh,'yyyy-mm-dd'),sonha,tenduong,quanhuyen,tinhtp,tiensubenh,tiensubenhgd,diungthuoc);
    strSQL :='CREATE USER "'||mabn||'" IDENTIFIED BY "'||mabn||'"';
    EXECUTE IMMEDIATE (strSQL);
    strSQL :='GRANT R_BENHNHAN TO "'||mabn||'"';
    EXECUTE IMMEDIATE (strSQL);
END;