-- a. Kich hoat viec ghi nhat ky toan he thong voi tham so audit_trail=DB,EXTENDED thi cot SQL_BIND se hien thi chi tiet gia tri
-- tu cau lenh SQL_TEXT, viec thay doi tham so nay phai restart lai instance:

ALTER SYSTEM SET audit_trail=DB,EXTENDED scope=spfile;



-- b. Thuc hien ghi nhan he thong dung standard audit: theo doi hanh vi cua tat ca các user cua he thong dang xay dung co su dung 
-- cac doi tuong su dung table, view tu schema QLCSYT va chi dinh theo doi cac hanh vi hien thanh cong

-- procedure để audit all quyen khi cac user thao tac voi cac table thuoc schema QLCSYT
CREATE OR REPLACE PROCEDURE Enable_Audit_Table
IS
    strSQL VARCHAR(2000);
BEGIN        
  FOR t IN (SELECT owner, table_name
              FROM all_tables
             WHERE owner like 'QLCSYT')
  LOOP
    strSQL := 'AUDIT ALL ON ' || t.owner || '.' || t.table_name || ' WHENEVER SUCCESSFUL';
    EXECUTE IMMEDIATE(strSQL);
  END LOOP;
END; 
/

EXEC Enable_Audit_Table;

-- procedure để audit all quyen khi cac user thao tac voi cac view thuoc schema QLCSYT
CREATE OR REPLACE PROCEDURE Enable_Audit_View
IS
    strSQL VARCHAR(2000);
BEGIN        
  FOR t IN (SELECT owner, view_name 
            FROM all_views
            WHERE owner like 'QLCSYT')
  LOOP
    strSQL := 'AUDIT ALL ON ' || t.owner || '.' || t.view_name || ' WHENEVER SUCCESSFUL';
    EXECUTE IMMEDIATE(strSQL);
  END LOOP;
END; 
/

EXEC Enable_Audit_View;


-- c. Thuc hien Fine-grained Audit


-- Tao policy de giam sat tat ca cac cau lenh (SELECT, UPDATE) tren bang QLCSYT.NHANVIEN de theo doi nhung cau truy van 
-- ma truy cap den cot SODT cua nhan vien co vai tro la 'Y si / Bac si'.

BEGIN
  DBMS_FGA.add_policy(
    object_schema   => 'QLCSYT',
    object_name     => 'NHANVIEN',
    policy_name     => 'FGA_YBacSi_AUDIT',
    audit_condition => 'VAITRO = ''Y si / Bac si''',
    audit_column    => 'SODT',
    statement_types => 'SELECT,UPDATE');
END;
/


-- d. Kiem tra du lieu nhat ky he thong


-- Doi voi truong hop Statement, Privilege, Schema Object
    -- Ket qua tra ve trong bang SYS.AUD$
    -- View: dba_audit_trail

SELECT USERNAME, OWNER, TIMESTAMP, OBJ_NAME, ACTION_NAME, SQL_TEXT from dba_audit_trail WHERE OWNER= 'QLCSYT';



-- Doi voi truong hop Fine-Grained Audit
    -- Ket qua tra ve trong bang FGA.LOG$
    -- View: dba_fga_audit_trail

SELECT TIMESTAMP, DB_USER, OBJECT_SCHEMA, OBJECT_NAME, POLICY_NAME, SQL_TEXT FROM dba_fga_audit_trail WHERE OBJECT_SCHEMA = 'QLCSYT';
