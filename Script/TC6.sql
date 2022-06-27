--View Table Nhan Vien
create or replace function nv_function(P_Schema varchar2, P_Object varchar2)
return varchar2
as
    usr varchar2(100);
    vt varchar2(100);
begin
    usr := sys_context('USERENV', 'SESSION_USER');
    if (usr like '%NV%') then
        select VAITRO into vt from QLCSYT.NHANVIEN where MANV = usr;
        if (vt = '') then 
            vt := 'A';
        end if;
    end if;
    if (usr like 'QLCSYT') then 
        usr := '';
    end if;
    if (vt like 'Thanh tra') then 
        usr := '';
    end if;
    return 'MANV LIKE ''%' || usr || '''';
end;

begin
    sys.dbms_rls.add_policy (
        object_schema => 'QLCSYT',
        object_name => 'NHANVIEN',
        policy_name => 'ViewNhanVien',
        policy_function => 'nv_function',
        statement_types => 'select, update',
        update_check => TRUE
    );
end;

--View Table Benh Nhan
create or replace function bn_function(P_Schema varchar2, P_Object varchar2)
return varchar2
as
    usr varchar2(100);
    vt varchar2(100);
begin
    usr := sys_context('USERENV', 'SESSION_USER');
    if (usr like '%NV%') then
        select VAITRO into vt from QLCSYT.NHANVIEN where MANV = usr;
        if (vt = '') then 
            vt := 'A';
        end if;
    end if;
    if (usr like 'QLCSYT') then 
        usr := '';
    end if;
    if (vt like 'Thanh tra') then 
        usr := '';
    end if;
    return 'MABN LIKE ''%' || usr || '''';
end;

begin
    sys.dbms_rls.add_policy (
        object_schema => 'QLCSYT',
        object_name => 'BENHNHAN',
        policy_name => 'ViewBenhNhan',
        policy_function => 'bn_function',
        statement_types => 'select, update',
        update_check => TRUE
    );
end;

grant select, update on qlcsyt.benhnhan to r_benhnhan;
grant select, update on qlcsyt.nhanvien to r_nhanvien;