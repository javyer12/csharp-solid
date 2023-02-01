using System.Text;

// namespace SingleResponsability
// {
//       public class ExportHelpers
//       {
//             public void ExportHelper(IEnumerable<Student> item, string type)
//             {
//                   string csv = String.Join(",", item.Select(x => x.ToString()).ToArray());
//                   System.Text.StringBuilder sb = new System.Text.StringBuilder();
//                   sb.AppendLine("Id;Fullname;Grades");
//                   foreach (var i in item)
//                   {
//                         sb.AppendLine($"{i.Id};{i.Fullname};{string.Join("|", i.Grades)}");
//                   }
//                   System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{type}.csv"), sb.ToString(), Encoding.Unicode);
//                   Console.WriteLine("From export class:");
//                   Console.WriteLine(sb);
//             }
//       }
// }
using System.Collections;
namespace SingleResponsability
{
      public class ExportHelper<T>
      {
            public void ExportToCSV(IEnumerable<T> items)
            {
                  System.Text.StringBuilder sb = new System.Text.StringBuilder();
                  string header = "";
                  string[] dataRows = new string[items.Count()];
                  foreach (var prop in typeof(T).GetProperties())
                  {
                        header += $"{prop.Name};";
                        for (int i = 0; i < items.Count(); i++)
                        {
                              var propValue = prop.GetValue(items.ToArray()[i]);
                              var propType = propValue.GetType();
                              if (propType.Name != nameof(String)
                                  && propType.GetInterface(nameof(IEnumerable)) != null)
                              {
                                    dataRows[i] += $"{String.Join("|", (propValue as IEnumerable).Cast<object>().Select(x => x.ToString()))};";
                              }
                              else
                              {
                                    dataRows[i] += $"{propValue};";
                              }
                        }
                  }
                  sb.AppendLine(header.Trim(';'));
                  foreach (var dataRow in dataRows)
                  {
                        sb.AppendLine(dataRow.Trim(';'));
                  }
                  System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Export_{typeof(T).ToString()}.csv"), sb.ToString(), Encoding.Unicode);

                  Console.WriteLine(sb);
            }
      }
}