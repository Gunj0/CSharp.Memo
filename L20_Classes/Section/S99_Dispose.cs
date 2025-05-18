// using Microsoft.Data.SqlClient;

// namespace CSharp.Memo.AdvancedSample
// {
//   /// <summary>
//   /// IDisposableを継承することで、Dispose()の実装を強制できる。
//   /// private変数で定義したものをDisposeしたい場合に使用する。
//   /// </summary>
//   internal class DisposeSample : IDisposable
//   {
//     internal void Sample()
//     {
//       // Disposeを直接書く場合
//       var sqlConnection = new SqlConnection();
//       try
//       {
//         sqlConnection.ConnectionString = "test.db";
//         sqlConnection.Open();
//         sqlConnection.Close();
//       }
//       catch (Exception ex)
//       {
//         Console.WriteLine(ex.ToString());
//       }
//       finally
//       {
//         sqlConnection.Dispose();
//       }

//       // usingを使う書き方
//       using (var sqlconnection2 = new SqlConnection())
//       {
//         sqlconnection2.Open();
//         sqlconnection2.Close();
//       }

//       // usingを使う最新の書き方
//       using var sqlconnection3 = new SqlConnection();
//       sqlconnection3.Open();
//       sqlconnection3.Close();
//     }

//     // メンバーなのでここでDisposeする処理を書けない
//     // →Dispose処理を書いておく必要がある。
//     private SqlDataAdapter _adapter = new SqlDataAdapter();

//     public void Dispose()
//     {
//       if (_adapter != null)
//       {
//         Console.WriteLine("～～DisposeSample～～");
//         Console.WriteLine("Dispose()があったら必ずDisposeする！");
//         Console.WriteLine("");
//         _adapter.Dispose();
//       }
//     }
//   }
// }
