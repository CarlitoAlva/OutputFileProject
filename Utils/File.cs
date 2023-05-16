using System.IO;
using System.Reflection;
using System.Text;
using OutputFilesProject.Models;

namespace OutputFilesProject.Utilities
{
    public static class File
    {
        public static string ConvertToCsv<T>(IEnumerable<T> data)
        {
            var sb = new StringBuilder();

            PropertyInfo[] propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                sb.Append(propertyInfo.Name).Append(",");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.AppendLine();

            foreach (T item in data)
            {
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    object value = propertyInfo.GetValue(item);
                    string stringValue = value != null ? value.ToString() : "";
                    sb.Append(stringValue).Append(",");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}