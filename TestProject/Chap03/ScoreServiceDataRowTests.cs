using Microsoft.VisualBasic;
using TargetProject.Chap02;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Chap02;

[TestClass]
public class ScoreServiceDataRowTests
{
    private ScoreService scoreservice = null!;
    [TestInitialize]
    public void SetUp()
    {
        // Arrange（準備）
        // テスト対象のオブジェクトを生成する
        // Arrange(準備)
        scoreservice = new ScoreService();//インスタンス生成
    }

    [DataTestMethod]
    [DataRow(80, true, DisplayName = "テストケース1: 合格点を上回る場合（代表値）は true を返す")]
    [DataRow(60, true, DisplayName = "テストケース2: 合格点ぴったり（境界値）の場合は true を返す")]
    [DataRow(100, true, DisplayName = "テストケース6: 最高点（100点）の場合は true を返す")]
    public void Return_TrueOrFalse(int score, bool expected)    //メソッド名（処理＋条件＋期待結果）
                                                                // true/falseはbool値なので注意
    {
        // Arrange(準備)
        // Act(実行)
        var result = scoreservice.IsPassed(score);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.IsTrue(result);//Assert.AreEqual(期待値expected, 実際actual)
    }

    [DataTestMethod]
    [DataRow(59, false, DisplayName = "テストケース3: 合格点に満たない場合（境界値）は false を返す")]
    [DataRow(40, false, DisplayName = "テストケース4: 合格点に満たない場合（代表値）は false を返す")]
    [DataRow(0, false, DisplayName = "テストケース5: 最低点（0点）の場合は false を返す")]
    public void Return_False(int score, bool expected)    //メソッド名（処理＋条件＋期待結果）
                                                          // true/falseはbool値なので注意
    {
        // Arrange(準備)
        // Act(実行)
        var result = scoreservice.IsPassed(score);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.IsFalse(result);//Assert.AreEqual(期待値expected, 実際actual)
    }
}