using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PathFinding
{
    internal class AStar
    {
        /* A* 알고리즘
         * 
         * 다익스트라 알고리즘을 확장하여 만든 최단경로 탐색알고리즘
		 * 경로 탐색의 우선순위를 두고 유망한 해부터 우선적으로 탐색
		 */

        // f = g + h        (g가 높은게 우선순위 높음)
        // f : 총예상거리 총점
        // g : 실제이동거리
        // h : 예상남은거리

        // 직선에 대비해 대각선은 1.4배

        // 휴리스틱
        // 멘허튼 : 가로+세로
        // 유클리드 : 직선+대각선

        const int CostStraight = 10;   // 직선코스트
        const int CostDiagonal = 14;    // 곡선코스트

        static Point[] Direction =
        {
            new Point( 0, +1), //상
            new Point( 0, -1), //하
            new Point( -1, 0), //좌
            new Point( +1, 0), //우
            new Point( -1, +1), //좌상
            new Point( -1, -1), //좌하
            new Point( +1, +1), //우상
            new Point( +1, -1), //우하
        };

        public static bool PathFinding(bool[,] tileMpa, Point start, Point end, out List<Point> path) // 타일맵제공후 시작부터 끝까지
        {
            int ySize = tileMpa.GetLength(0);
            int xSize = tileMpa.GetLength(1);

            ASNode[,] nodes = new ASNode[ySize, xSize];
            bool[,] visited = new bool[ySize, xSize];
            PriorityQueue<ASNode, int> pq = new PriorityQueue<ASNode, int>();

            // 0. 시작 정점을 생섷하여 추가
            ASNode startNode = new ASNode(start, new Point(), 0, Heruistic(end, start));
            nodes[startNode.pos.y, startNode.pos.x] = startNode;
            pq.Enqueue(startNode, startNode.f);

            while (pq.Count > 0)
            {
                // 1. 다음으로 탐색할 정점 꺼내기 : f가 가장 낮은 정점
                ASNode nextNode = pq.Dequeue();

                // 2. 탐색한 정점은 방문표시
                visited[nextNode.pos.y, nextNode.pos.x] = true;

                // 3. 탐색할 정점이 도착지인 경우
                // 도착했다가 판단해서 경로를 반환
                if (nextNode.pos.x == end.x && nextNode.pos.y == end.y)
                {
                    path = new List<Point>();
                    Point point = end;

                    while (false ==(point.x == start.x && point.y == start.y))
                    {
                        path.Add(point);
                        point = nodes[point.y, point.x].parent;
                    }
                    path.Add(start);
                    path.Reverse();     // 지금까지 경로를 반전
                    return true;
                }

                // 4. 탐색한 정점 주변의 정점의 점수 계산 (대각선여부에 따라서 4, 8)
                for (int i = 0; i < Direction.Length; i++)
                {
                    int x = nextNode.pos.x + Direction[i].x;
                    int y = nextNode.pos.y + Direction[i].y;

                    // 4-1 점수계산을 하면 안되는 경우
                    // 맵을 벗어난 경우
                    if (x < 0 || x >= xSize || y < 0 || y >= ySize)
                        continue;

                    // 탐색할 수 없는 타일맵인 경우
                    else if (tileMpa[y, x] == false)
                        continue;

                    // 이미 탐색한 정점일 경우
                    else if (visited[y, x])
                        continue;

                    // 대각선으로 이동이 불가능 지역인 경우
                    else if (i >= 4 && tileMpa[y, nextNode.pos.x] == false && tileMpa[nextNode.pos.y, x] == false)
                        continue;


                    // 4-2 점수를 계산한 정점 만들기
                    int g = nextNode.g + i < 4 ? CostStraight : CostDiagonal;
                    int h = Heruistic(new Point(x, y), end);
                    ASNode newNode = new ASNode(new Point(x, y), nextNode.pos, g, h);

                    // 4-3. 정점이 갱신이 필요한 경우 새로운 정점으로 할당
                    if (nodes[y, x] == null ||       // 점수 계산을 하지 않은 정점이거나
                        nodes[y, x].f > newNode.f)   // 새로운 정점의 f 가중치가 더 낮은경우
                    {
                        nodes[y, x] = newNode;
                        pq.Enqueue(newNode, newNode.f);
                    }
                }
            }

            path = null;
            return false;

        }

        public static int Heruistic(Point start, Point end)
        {
            int xSize = Math.Abs(start.x - end.x);  // Math.Abs 절대값 음수를 양수로
            int ySize = Math.Abs(start.y - end.y);

            // 맨허튼 거리 : 직선을 통해 이동하는 거리
            // 계산은 빠르니 정확하지 않음
            //return CostStaringht * (xSize + ySize);


            // 유클리드 거리 : 대각선을 통해 이동하는 거리
            //return CostStaringht * (int )Math.Sqrt(xSize* xSize +ySize * ySize);

            // 타일맵 유클리드 거리 : 직선과 대각선을 통해 이동하는 거리
            int straightCount = Math.Abs(xSize - ySize);
            int diagonalCount = Math.Max(xSize, ySize) - straightCount;
            return CostStraight * straightCount + CostDiagonal * diagonalCount;

            // 다익스트라
            return 0;
        }

        public class ASNode
        {
            public Point pos;    // 정점의 위치
            public Point parent; // 이 정점을 탐색한 점점의 위치

            public int f;   // 총 예상거리 : f = g + h
            public int g;   // 지금까지 이동한거리
            public int h;   // 휴리스틱, 앞으로 예상되는 가중치,  목표까지 추정 경로 가중치(장애물 고려X)

            public ASNode(Point pos, Point parent, int g, int h)
            {
                this.pos = pos;
                this.parent = parent;
                this.f = g + h;
                this.g = g;
                this.h = h;
            }

        }
    }

    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}