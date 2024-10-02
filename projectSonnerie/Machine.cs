using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectSonnerie
{
    internal class Machine
    {
        private float _temperateur;
        Thread _TrtacherTemperateur = new Thread(new()=> _TrtacherTemperateur());
        List<Alarme> alarmes;
        public Machine() {
            _alarmes = new List<Alarme>();
            _TrtacherTemperateur.Start();
        }
        void _TrtacherTemperateur() {
            while (true) {
                float _temperateur = Get_temperateur();
                if (_temperateur > 90) {

                    foreach (Alarme m in _alarmes)
                        m.Sonnee();
                }
            }
        
        }
    }
}
