using System;
using System.IO;

namespace NKaiju
{
    class IncorectedVersionExeption : Exception
    {
        public IncorectedVersionExeption(float version, string className)
            : base()
        {
            WriteErrorlList(version, className, base.Message, base.StackTrace);
        }

        public IncorectedVersionExeption(float version, string className, string message)
            : base(message)
        {
            WriteErrorlList(version, className, message, base.StackTrace);
        }

        public IncorectedVersionExeption(float version, string className, string message, Exception ex)
            : base(message, ex)
        {
            WriteErrorlList(version, className, message, base.StackTrace, ex);
        }

        void WriteErrorlList(float version, string className, string messge, string stackTrace, Exception innerExeption = null)
        {
            if (!File.Exists(Resource_1.ErrorListPath))
            {
                return;
            }
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(Resource_1.ErrorListPath, true);
                sw.WriteLine("Error Version:");
                sw.WriteLine("Class name:" + className);
                sw.WriteLine("Incorrected version:" + version);
                sw.WriteLine("Message:" + messge);
                sw.WriteLine("StackTrace:" + stackTrace);
                if (innerExeption != null)
                {
                    sw.WriteLine("Inner Exeption:" + InnerException.Message);
                }
                else
                {
                    sw.WriteLine("Inner Exeprion: no.");
                }
                sw.WriteLine();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public void WriteErrolListCatchExeption()
        {
            if (!File.Exists(Resource_1.ErrorListPath))
            {
                return;
            }
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(Resource_1.ErrorListPath, true);
                sw.WriteLine("Перехватили исключение IncorectedVersionExeption.");
                sw.WriteLine("Date:" + DateTime.Now);
                sw.WriteLine();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}
