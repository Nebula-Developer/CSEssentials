using CSEssentials.Mathematics.General;

namespace CSEssentials.Tests;

public class EasingTests
{
    [Fact] public void Lerp() => Assert.Equal(1, EMath.Lerp(0, 2, 0.5f));
    [Fact] public void LerpDouble() => Assert.Equal(1, EMath.Lerp(0, 2, 0.5));

    [Fact] public void EaseInOutSine() => Assert.Equal(0.5, Easing.Ease(0, 1, 0.5f, EaseType.InOutSine));
    [Fact] public void EaseInOutExpo() => Assert.Equal(0.015625, Easing.Ease(0, 1, 0.25f, EaseType.InOutExpo));
}
