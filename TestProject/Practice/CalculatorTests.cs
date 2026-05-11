using TargetProject.Practice;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Practice;

[TestClass]
public class CalculatorTests
{
    [TestMethod("テストケース1:両方に値がある場合、加算結果を返す")]//[TestMthod("表示名")
    public void Add_ShouldReturnSum_WhenBothHaveValues()//メソッド名（処理＋条件＋期待結果）
                                                        //public / void / 引数なし　で記述する
    {
        // Arrange(準備)
        var calculator = new Calculator();//インスタンス生成
        int? x = 1;//代入
        int? y = 2;
        // Act(実行)
        var result = calculator.Add(x, y);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.AreEqual(3, result);//Assert.AreEqual(期待値expected, 実際actual)
    }
    [TestMethod("テストケース2:xがnullの場合、結果はnullになる")]
    public void Add_ShouldReturnNull_WhenXIsNull()
    {
        // Arrange(準備)
        var calculator = new Calculator();
        int? x = null;
        int? y = 2;
        // Act(実行)
        var result = calculator.Add(x, y);
        // Assert(確認)
        Assert.IsNull(result);//値がnullかどうか判定するAssertメソッド
    }
    [TestMethod("テストケース3:yがnullの場合、結果はnullになる")]
    public void Add_ShouldReturnNull_WhenYIsNull()
    {
        // Arrange(準備)
        var calculator = new Calculator();
        int? x = 1;
        int? y = null;
        // Act(実行)
        var result = calculator.Add(x, y);
        // Assert(確認)
        Assert.IsNull(result);
    }
    [TestMethod("テストケース4:両方がnullの場合、結果はnullになる")]
    public void Add_ShouldReturnNull_WhenBothAreNull()
    {
        // Arrange(準備)
        var calculator = new Calculator();
        int? x = null;
        int? y = null;
        // Act(実行)
        var result = calculator.Add(x, y);
        // Assert(確認)
        Assert.IsNull(result);
    }
}