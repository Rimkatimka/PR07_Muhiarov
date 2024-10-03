using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PR07_Muhiarov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int p = 3;
        public MainWindow()
        {
            TowerOfHanoi game = new TowerOfHanoi();
            InitializeComponent();
        }
        public class Tower
        {
            public int RingCount { get; set; }
            public int[] Rings { get; private set; }

            public Tower(int maxRingCount)
            {
                RingCount = 0;
                Rings = new int[maxRingCount];
            }

            public void MoveRing(Tower targetTower)
            {
                if (RingCount > 0)
                {
                    if (targetTower.RingCount > 0)
                    {
                        if (Rings[RingCount - 1] >= targetTower.Rings[targetTower.RingCount - 1])
                        {
                            throw new InvalidOperationException("Cannot place a larger ring on top of a smaller ring.");
                        }
                    }

                    targetTower.Rings[targetTower.RingCount] = Rings[RingCount - 1];
                    Rings[RingCount - 1] = 0;
                    RingCount--;
                    targetTower.RingCount++;
                }
                else
                {
                    throw new InvalidOperationException("There are no rings to move.");
                }
            }
        }

        public class TowerOfHanoi
        {
            private const int MaxRingCount = 5;
            private Tower[] towers;

            public TowerOfHanoi()
            {
                towers = new Tower[3];
                for (int i = 0; i < towers.Length; i++)
                {
                    towers[i] = new Tower(MaxRingCount);
                }
                InitTowers();
            }

            private void InitTowers()
            {
                towers[0].RingCount = MaxRingCount;
                for (int i = 0; i < MaxRingCount; i++)
                {
                    towers[0].Rings[i] = MaxRingCount - i;
                }
            }
        }

    }
}
