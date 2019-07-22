using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SB.Tools.Classes.DataBase
{
    public class General
    {
        public static General Default = new General();

        public void CreateSqlJobFileForBackUp(List<string> lstDataBasesName, System.Data.SqlClient.SqlConnection connection, bool withFilePass, string filePass, string saveFolderPath, int hour, int minute, int secound)
        {
            string runBackupText = string.Empty;
            string jobName = "JobBackup_";

            #region --> Create Backup text

            runBackupText += "declare @DateFolderName nvarchar(100)" + Environment.NewLine +
                               "set @DateFolderName = CONVERT(nvarchar(250), GETDATE(), 20)" + Environment.NewLine +
                               "set @DateFolderName = Replace(@DateFolderName, '':'', ''-'')" + Environment.NewLine;

            runBackupText += Environment.NewLine + "declare @tempText Nvarchar(1000)" + Environment.NewLine + Environment.NewLine;
            runBackupText += "Set @tempText =  N''" + saveFolderPath + System.IO.Path.DirectorySeparatorChar + "'' + @DateFolderName" + Environment.NewLine;
            runBackupText += "EXECUTE master.dbo.xp_create_subdir @tempText" + Environment.NewLine + Environment.NewLine;


            foreach (string itemDBName in lstDataBasesName)
            {
                runBackupText += Environment.NewLine + Environment.NewLine +
                           "Set @tempText =  N''" + saveFolderPath + System.IO.Path.DirectorySeparatorChar + "'' + @DateFolderName + N''" + System.IO.Path.DirectorySeparatorChar + itemDBName + ".bak''" + Environment.NewLine +
                           "BACKUP DATABASE [" + itemDBName + "] TO  " +
                           "DISK = @tempText " +
                           "WITH NOFORMAT, NOINIT,  NAME = N''" + itemDBName + "-Full Database Backup'', " +
                           "SKIP, NOREWIND, NOUNLOAD " + (withFilePass ? (",password = N''" + filePass + "''") : string.Empty) + ", STATS = 10";

                jobName += "_" + itemDBName;
            }

            #endregion //Create Backup text

            CreateSqlJobFile(jobName, connection, runBackupText, hour, minute, secound);
        }

        public void CreateSqlJobFile(string jobName, System.Data.SqlClient.SqlConnection connection, string jobTransaction, int hour, int minute, int secound)
        {
            string strJobFileText = string.Empty;

            #region --> Create Job Text

            strJobFileText = "USE [msdb]" + Environment.NewLine +
 Environment.NewLine + Environment.NewLine +
"/****** Object:  Job [" + jobName + "]    Script Date: 09/27/2012 19:28:48 ******/" + Environment.NewLine +
"BEGIN TRANSACTION" + Environment.NewLine +
"DECLARE @ReturnCode INT" + Environment.NewLine +
"SELECT @ReturnCode = 0" + Environment.NewLine +
"/****** Object:  JobCategory [Database Maintenance]    Script Date: 09/27/2012 19:28:48 ******/" + Environment.NewLine +
"IF NOT EXISTS (SELECT name FROM msdb.dbo.syscategories WHERE name=N'Database Maintenance' AND category_class=1)" + Environment.NewLine +
"BEGIN" + Environment.NewLine +
"EXEC @ReturnCode = msdb.dbo.sp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'Database Maintenance'" + Environment.NewLine +
"IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback" + Environment.NewLine +

"END" + Environment.NewLine + Environment.NewLine +

"DECLARE @jobId BINARY(16)" + Environment.NewLine +
"EXEC @ReturnCode =  msdb.dbo.sp_add_job @job_name=N'" + jobName + "', " + Environment.NewLine +
"		@enabled=1, " + Environment.NewLine +
"		@notify_level_eventlog=0, " + Environment.NewLine +
"		@notify_level_email=0, " + Environment.NewLine +
"		@notify_level_netsend=0, " + Environment.NewLine +
"		@notify_level_page=0, " + Environment.NewLine +
"		@delete_level=0, " + Environment.NewLine +
"		@description=N'This Job Create by ali seifaei for auto backup', " + Environment.NewLine +
"		@category_name=N'Database Maintenance', " + Environment.NewLine +
"		@owner_login_name=N'sa', @job_id = @jobId OUTPUT" + Environment.NewLine +
"IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback" + Environment.NewLine +
"/****** Object:  Step [Step_CreateBackup]    Script Date: 09/27/2012 19:28:49 ******/" + Environment.NewLine +
"EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'Step_CreateBackup', " + Environment.NewLine +
"		@step_id=1, " + Environment.NewLine +
"		@cmdexec_success_code=0, " + Environment.NewLine +
"		@on_success_action=1, " + Environment.NewLine +
"		@on_success_step_id=0, " + Environment.NewLine +
"		@on_fail_action=2, " + Environment.NewLine +
"		@on_fail_step_id=0, " + Environment.NewLine +
"		@retry_attempts=0, " + Environment.NewLine +
"		@retry_interval=0, " + Environment.NewLine +
"		@os_run_priority=0, @subsystem=N'TSQL', " + Environment.NewLine +
"       @command=N'" + jobTransaction + Environment.NewLine + "'," + Environment.NewLine +

"		@database_name=N'master', " + Environment.NewLine +
"		@flags=0" + Environment.NewLine +
"IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback" + Environment.NewLine +
"EXEC @ReturnCode = msdb.dbo.sp_update_job @job_id = @jobId, @start_step_id = 1" + Environment.NewLine +
"IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback" + Environment.NewLine +
"EXEC @ReturnCode = msdb.dbo.sp_add_jobschedule @job_id=@jobId, @name=N'Schedule_CreateBackup', " + Environment.NewLine +
"		@enabled=1, " + Environment.NewLine +
"		@freq_type=4, " + Environment.NewLine +
"		@freq_interval=1, " + Environment.NewLine +
"		@freq_subday_type=1, " + Environment.NewLine +
"		@freq_subday_interval=0, " + Environment.NewLine +
"		@freq_relative_interval=0, " + Environment.NewLine +
"		@freq_recurrence_factor=0, " + Environment.NewLine +
"		@active_start_date=20000506, " + Environment.NewLine +
"		@active_end_date=99991231, " + Environment.NewLine +
"		@active_start_time=" + hour.ToString("00") + minute.ToString("00") + secound.ToString("00") + ", " + Environment.NewLine +
"		@active_end_time=050505, " + Environment.NewLine +
"		@schedule_uid=N'" + Guid.NewGuid().ToString() + "'" + Environment.NewLine +
"IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback" + Environment.NewLine +
"EXEC @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'" + Environment.NewLine +
"IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback" + Environment.NewLine +
"COMMIT TRANSACTION" + Environment.NewLine +
"GOTO EndSave" + Environment.NewLine +
"QuitWithRollback:" + Environment.NewLine +
"    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION" + Environment.NewLine +
"EndSave:" + Environment.NewLine;


            #endregion //Create Job Text

            System.Data.SqlClient.SqlCommand objCommand = new System.Data.SqlClient.SqlCommand(string.Empty, connection);

            #region --> Check jobs

            objCommand.CommandText = "use msdb EXEC MSDB.DBO.sp_HELP_JOB";

            DataTable tblJobInfo = new DataTable();
            System.Data.SqlClient.SqlDataAdapter objDataAdapter = new System.Data.SqlClient.SqlDataAdapter(objCommand);
            objDataAdapter.Fill(tblJobInfo);

            foreach (DataRow itemRow in tblJobInfo.Rows)
            {
                if (itemRow["name"].ToString() == jobName)
                {
                    connection.Open();
                    objCommand.CommandText = "use msdb EXEC msdb.dbo.sp_delete_job @job_id=N'" + itemRow["job_id"].ToString() + "', @delete_unused_schedule=1";
                    objCommand.ExecuteNonQuery();
                    connection.Close();
                    break;
                }
            }

            #endregion //Check jobs

            objCommand.CommandText = strJobFileText;
            connection.Open();
            objCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
