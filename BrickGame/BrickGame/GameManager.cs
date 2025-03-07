using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class GameManager
    {
        Ball m_pBall = null;
        Bar m_pBar = null;

        public void Initialize()
        {
            //볼 생성
            if(m_pBall == null)
            {
                m_pBall = new Ball();
                m_pBall.Initialize();
            }


            //바생성
            if(m_pBar == null)
            {
                m_pBar = new Bar();
                m_pBar.Initialize();
            }

            m_pBall.SetBar(m_pBar);


        }

        public void Progress()
        {
            m_pBall.Progress();
            m_pBar.Progress(ref m_pBall);
        }

        public void Render()
        {
            Console.Clear();
            m_pBall.Render();
            m_pBar.Render();
        }

        public void Release()
        {
            m_pBall.Release();
            m_pBar.Release();
        }

    }
}
