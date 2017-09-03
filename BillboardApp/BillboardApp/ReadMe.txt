
#Enable Migrations
Enable-Migrations -ContextTypeName BillboardApp.DAL.BillboardContext

#Enable automatic migrations
Enable-Migrations -EnableAutomaticMigrations -Force

#Add Migrations
Add-Migration Initial
Add-Migration Initial -Force
Update-Database -TargetMigration $InitialDatabase


#Update database
Update-Database -Verbose -ConfigurationType Configuration -Force
Update-Database -Verbose

#Date format
01/09/2005 00:00:00
+


#install async pagedlist component
Install-Package PagedList.Mvc

##Restore to previous good migration
Update-Database –TargetMigration:Initial

