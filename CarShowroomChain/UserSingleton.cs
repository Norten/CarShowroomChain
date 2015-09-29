using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomChain
{
    public sealed class UserSingleton
    {
        private static UserSingleton m_oInstance = null;
        //private int user_id = 0;

        public static UserSingleton Instance
        {
            get
            {
                if (m_oInstance == null)
                {
                    m_oInstance = new UserSingleton();
                }
                return m_oInstance;
            }
        }

        public int userId { get; set; }

        public int userRole { get; set; }

        private UserSingleton() { }
    }
}
