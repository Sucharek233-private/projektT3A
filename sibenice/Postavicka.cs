namespace sibenice {
    internal class Postavicka {
        public Postavicka() {
            InitParts();
        }

        const int postavickaSize = 200;

        enum PartType {
            Line,
            Circle
        }

        struct Part {
            public PartType Type;
            public Point A;
            public Point B;
            public int Radius;
        }

        private List<Part> parts;

        private void InitParts() {
            parts = [
                new() { Type = PartType.Line  , A = new Point(10, 180),  B = new Point(100,180) }, // základna
                new() { Type = PartType.Line  , A = new Point(55, 180),  B = new Point(55,20 )  }, // sloup
                new() { Type = PartType.Line  , A = new Point(55, 20),   B = new Point(130,20)  }, // trám
                new() { Type = PartType.Line  , A = new Point(130, 20),  B = new Point(130,50)  }, // provaz
                new() { Type = PartType.Circle, A = new Point(130, 65),  Radius = 15            }, // hlava
                new() { Type = PartType.Line  , A = new Point(130, 80),  B = new Point(130,130) }, // tělo
                new() { Type = PartType.Line  , A = new Point(130, 90),  B = new Point(110,110) }, // levá ruka
                new() { Type = PartType.Line  , A = new Point(130, 90),  B = new Point(150,110) }, // pravá ruka
                new() { Type = PartType.Line  , A = new Point(130, 130), B = new Point(110,160) }, // levá noha
                new() { Type = PartType.Line  , A = new Point(130, 130), B = new Point(150,160) }  // pravá noha
            ];
        }

        public void Paint(Graphics g, int pokusy, Point velikost) {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Point posunutiNaStred = new((velikost.X - postavickaSize) / 2, (velikost.Y - postavickaSize) / 2);

            for (int i = 0; i < pokusy && i < parts.Count; i++) {
                Part p = parts[i];
                if (p.Type == PartType.Line) {
                    g.DrawLine(
                        Pens.Black,
                        p.A.X + posunutiNaStred.X,
                        p.A.Y + posunutiNaStred.Y,
                        p.B.X + posunutiNaStred.X,
                        p.B.Y + posunutiNaStred.Y
                    );
                } else if (p.Type == PartType.Circle) {
                    g.DrawEllipse(
                        Pens.Black,
                        p.A.X - p.Radius + posunutiNaStred.X,
                        p.A.Y - p.Radius + posunutiNaStred.Y,
                        p.Radius * 2,
                        p.Radius * 2
                    );
                }
            }
        }

    }
}