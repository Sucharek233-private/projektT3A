using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sibenice {
    internal class Postavicka {
        private class LinePart {
            public Point Start { get; set; }
            public Point End { get; set; }
        }

        private class CirclePart {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }

        private List<object> parts;

        public void InitParts() {
            parts = new List<object> {
                new LinePart   { Start =  new Point(10, 180),  End = new Point(100, 180) }, // základna
                new LinePart   { Start =  new Point(55, 180),  End = new Point(55, 20) },   // sloup
                new LinePart   { Start =  new Point(55, 20),   End = new Point(130, 20) },  // trám
                new LinePart   { Start =  new Point(130, 20),  End = new Point(130, 50) },  // provaz
                new CirclePart { Center = new Point(130, 65),  Radius = 15 },               // hlava
                new LinePart   { Start =  new Point(130, 80),  End = new Point(130, 130) }, // tělo
                new LinePart   { Start =  new Point(130, 90),  End = new Point(110, 110) }, // levá ruka
                new LinePart   { Start =  new Point(130, 90),  End = new Point(150, 110) }, // pravá ruka
                new LinePart   { Start =  new Point(130, 130), End = new Point(110, 160) }, // levá noha
                new LinePart   { Start =  new Point(130, 130), End = new Point(150, 160) }  // pravá noha
            };
        }

        public void Paint(Graphics g, int pokusy, Point posunutiNaStred) {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = 0; i < pokusy && i < parts.Count; i++) {
                if (parts[i] is LinePart lp) {
                    g.DrawLine(Pens.Black,
                               lp.Start.X + posunutiNaStred.X, lp.Start.Y + posunutiNaStred.Y,
                               lp.End.X + posunutiNaStred.X, lp.End.Y + posunutiNaStred.Y);
                } else if (parts[i] is CirclePart cp) {
                    g.DrawEllipse(
                        Pens.Black,
                        cp.Center.X - cp.Radius + posunutiNaStred.X,
                        cp.Center.Y - cp.Radius + posunutiNaStred.Y,
                        cp.Radius * 2,
                        cp.Radius * 2
                    );
                }
            }
        }

    }
}
