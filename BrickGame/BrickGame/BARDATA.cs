using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class BARDATA //바를 그리는 데이터
    {
        public int[] nX = new int[3]; //네모박스 세개를 그려서 그 세개가 움직이게 할거라서 
                                                    //세개가 한번에 움직여야하므로 배열로 선언
        public int nY; //Y로는 안움직이겟지만 처음에 그려줄 Y좌표는 정해줘야되니까
    }
}
