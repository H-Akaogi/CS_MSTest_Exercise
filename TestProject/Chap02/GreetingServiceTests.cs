using TargetProject.Chap02;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Chap02;

[TestClass]
public class GreetingServiceTests
{
    [TestMethod("テストケース1: 朝の時間帯(代表値7時)ではGood Morningを返す")]
    public void Return_Moning_GoodMorning() //メソッド名（処理＋条件＋期待結果）
    {
        // Arrange(準備)
        var greetingservice = new GreetingService();//インスタンス生成
        int hour = 7;//代入
        // Act(実行)
        var result = greetingservice.Greet(hour);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.AreEqual("Good Morning", result);//Assert.AreEqual(期待値expected, 実際actual)
    }
    [TestMethod("テストケース2: 昼の時間帯(代表値12時)ではHelloを返す")]
    public void Return_Noon_Hello() //メソッド名（処理＋条件＋期待結果）
    {
        // Arrange(準備)
        var greetingservice = new GreetingService();//インスタンス生成
        int hour = 12;//代入
        // Act(実行)
        var result = greetingservice.Greet(hour);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.AreEqual("Hello", result);//Assert.AreEqual(期待値expected, 実際actual)
    }
    [TestMethod("テストケース3: 夕方の時間帯(代表値18時)ではGood Eveningを返す")]
    public void Return_Evening_GoodEvening() //メソッド名（処理＋条件＋期待結果）
    {
        // Arrange(準備)
        var greetingservice = new GreetingService();//インスタンス生成
        int hour = 18;//代入
        // Act(実行)
        var result = greetingservice.Greet(hour);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.AreEqual("Good Evening", result);//Assert.AreEqual(期待値expected, 実際actual)
    }
    [TestMethod("テストケース4: 深夜の時間帯(代表値21時)ではGood Nightを返す")]
    public void Return_MidNight_GoodNight() //メソッド名（処理＋条件＋期待結果）
    {
        // Arrange(準備)
        var greetingservice = new GreetingService();//インスタンス生成
        int hour = 21;//代入
        // Act(実行)
        var result = greetingservice.Greet(hour);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.AreEqual("Good Night", result);//Assert.AreEqual(期待値expected, 実際actual)
    }
    [TestMethod("テストケース5: 早朝の時間帯(代表値6時)ではGood Nightを返す")]
    public void Return_beforeMorning_GoodNight() //メソッド名（処理＋条件＋期待結果）
    {
        // Arrange(準備)
        var greetingservice = new GreetingService();//インスタンス生成
        int hour = 6;//代入
        // Act(実行)
        var result = greetingservice.Greet(hour);
        // Assert(確認)：期待通りかどうかを判定するAssertメソッド
        Assert.AreEqual("Good Night", result);//Assert.AreEqual(期待値expected, 実際actual)
    }
}