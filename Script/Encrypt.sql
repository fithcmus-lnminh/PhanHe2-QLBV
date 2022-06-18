--Ham ma hoa
create or replace function ENCRYPT_DATA(P_DATA varchar2, P_KEY varchar2 default 'NH18_563_566_581')
return varchar2
is   
    V_ENCRYPTED_RAW RAW(2048);
    V_ENCRYPTION_TYPE  PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_AES128 + DBMS_CRYPTO.CHAIN_CBC + DBMS_CRYPTO.PAD_PKCS5;     
begin
  V_ENCRYPTED_RAW := DBMS_CRYPTO.ENCRYPT(SRC => UTL_I18N.STRING_TO_RAW(P_DATA, 'AL32UTF8'), 
                                         KEY => UTL_I18N.STRING_TO_RAW(P_KEY, 'AL32UTF8'),
                                         TYP => V_ENCRYPTION_TYPE);
  return RAWTOHEX(V_ENCRYPTED_RAW);
end;

--Ham giai ma
create or replace function DECRYPT_DATA(P_DATA RAW, P_KEY varchar2 default 'NH18_563_566_581')
return varchar2
is 
    V_DECRYPTED_RAW RAW(2048);
    V_ENCRYPTION_TYPE  PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_AES128 + DBMS_CRYPTO.CHAIN_CBC + DBMS_CRYPTO.PAD_PKCS5;       
begin
  V_DECRYPTED_RAW := DBMS_CRYPTO.DECRYPT(SRC => HEXTORAW(P_DATA), 
                                         KEY => UTL_I18N.STRING_TO_RAW(P_KEY, 'AL32UTF8'),
                                         TYP => V_ENCRYPTION_TYPE);
  return UTL_I18N.RAW_TO_CHAR(V_DECRYPTED_RAW);
end;