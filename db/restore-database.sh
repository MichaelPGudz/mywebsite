#!/usr/bin/env bash

db_user=$1
db_password=$2
db_container_name=${3:-mywebsite-db}
backup_file_location=${4:-./backup/MyWebsiteDb.bak}
restore_script=${5:-./restore-backup.sql}
tmp_location=/tmp

GREEN='\033[0;32m'
RED='\033[0;31m'

docker cp $backup_file_location $db_container_name:$tmp_location
docker cp $restore_script $db_container_name:$tmp_location

echo "Entering the $db_container_name...\n"
docker exec -it $db_container_name sh -c "
echo 'Running restore-script...';
/opt/mssql-tools/bin/sqlcmd -S localhost -U $db_user -P "$db_password" -i $tmp_location/restore-backup.sql;
exit;" && 

echo -e "\n${GREEN}Restore process completed succesfully" ||
echo -e "\n${RED}Something went wrong, please try again" 