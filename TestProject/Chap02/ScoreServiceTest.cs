using TargetProject.Chap02;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Chap02;

[TestClass]
public class ScoreServiceTest
{
    [TestMethod("テストケース1: 合格点を大きく上回る場合は true を返す")]
    public void ReturnTrue_Over60_True() //メソッド名（処理＋条件＋期待結果）
    {
        // Arrange(準備)
        var scoreservice = new ScoreService();//インスタンス生成
        int score = 80;//代入
        // Act(実行)
        var result = scoreservice.IsPassed(score);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.IsTrue(result);//Assert.AreEqual(期待値expected, 実際actual)
    }
    [TestMethod("テストケース2: 合格点ぴったりの場合は true を返す")]
    public void ReturnTrue_60_True() //メソッド名（処理＋条件＋期待結果）
    {
        // Arrange(準備)
        var scoreservice = new ScoreService();//インスタンス生成
        int score = 60;//代入
        // Act(実行)
        var result = scoreservice.IsPassed(score);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.IsTrue(result);//Assert.AreEqual(期待値expected, 実際actual)
    }
    [TestMethod("テストケース3: 合格点に満たない場合は false を返す")]
    public void ReturnTrue_59_False() //メソッド名（処理＋条件＋期待結果）
    {
        // Arrange(準備)
        var scoreservice = new ScoreService();//インスタンス生成
        int score = 59;//代入
        // Act(実行)
        var result = scoreservice.IsPassed(score);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.IsFalse(result);//Assert.AreEqual(期待値expected, 実際actual)
    }
    [TestMethod("テストケース4: 合格点を大きく下回る場合は false を返す")]
    public void ReturnTrue_Under60_False() //メソッド名（処理＋条件＋期待結果）
    {
        // Arrange(準備)
        var scoreservice = new ScoreService();//インスタンス生成
        int score = 0;//代入
        // Act(実行)
        var result = scoreservice.IsPassed(score);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.IsFalse(result);//Assert.AreEqual(期待値expected, 実際actual)
    }
}