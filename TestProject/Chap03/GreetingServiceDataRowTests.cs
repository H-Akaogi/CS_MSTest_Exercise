using TargetProject.Chap02;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Chap02;

[TestClass]
public class GreetingServiceDataRowTests
{
    /// <summary>
    /// テストターゲットのGreetingServiceを格納するフィールド
    /// </summary>
    private GreetingService? greetingservice;
    [TestInitialize]
    /// <summary>
    /// テストメソッド実行前処理
    /// </summary>
    public void SetUp()
    {
        // Arrange（準備）
        // テスト対象のオブジェクトを生成する
        // Arrange(準備)
        greetingservice = new GreetingService();//インスタンス生成
    }
    [DataTestMethod]
    [DataRow(7, "Good Morning", DisplayName = "テストケース1: 朝の時間帯(代表値7時)ではGood Morningを返す")]
    [DataRow(11, "Good Morning", DisplayName = "テストケース2: 朝の時間帯(代表値11時)ではGood Morningを返す")]
    [DataRow(12, "Hello", DisplayName = "テストケース3: 昼の時間帯(12時)ではHelloを返す")]
    [DataRow(17, "Hello", DisplayName = "テストケース4: 昼の時間帯(代表値17時)ではHelloを返す")]
    [DataRow(18, "Good Evening", DisplayName = "テストケース5: 夕方の時間帯(代表値18時)ではGood Eveningを返す")]
    [DataRow(20, "Good Evening", DisplayName = "テストケース6: 夕方の時間帯(20時)ではGood Eveningを返す")]
    [DataRow(21, "Good Night", DisplayName = "テストケース7: 深夜の時間帯(代表値21時)ではGood Nightを返す")]
    [DataRow(6, "Good Night", DisplayName = "テストケース8: 6時は朝に含まれずGood Nightを返す")]

    public void Return_Greeting(int hour, string expected)
    {
        // Act（実行）
        // テスト対象のメソッドを実行する
        var result = greetingservice!.Greet(hour);

        // Assert（確認）：期待通りかどうかを判定するAssertメソッド
        // 実行結果が期待した値と一致するか確認する
        Assert.AreEqual(expected, result);//Assert.AreEqual(期待値expected, 実際actual)
    }

}