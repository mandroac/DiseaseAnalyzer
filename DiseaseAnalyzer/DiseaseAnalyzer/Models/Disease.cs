using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseaseAnalyzer.Models
{
    public class Disease
    {
        [Key]
        public int Disease_ID { get; set; }
        public string Disease_Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Disease_Description { get; set; }


        public int? Temperature_Symptom_Value { get; set; } // Температура
        public int? Cold_Symptom_Value { get; set; } // Нежить
        public int? Cough_Symptom_Value { get; set; } // Кашель
        public int? Throating_Symptom_Value { get; set; } // Біль у горлі
        public int? Jaw_Gland_Symptom_Value { get; set; } // Збільшення підчелюсних залоз
        public int? Breathlessness_Symptom_Value { get; set; } // Задишка
        public int? Rash_Symptom_Value { get; set; } // Висипка
        public int? Vomitting_Symptom_Value { get; set; } // Тошнота/рвота
        public int? Ear_Gland_Symptom_Value { get; set; } // Опухлість завушних залоз
        public int? Stomach_Ache_Symptom_Value { get; set; } // Біль у животі
        public int? Intestine_Disorder_Symptom_Value { get; set; } // Розлади кишківника
        public int? Yellolwish_Skin_Symptom_Value { get; set; } // Пожовтіння шкіри
        public int? Head_Ache_Symptom_Value { get; set; } // Головний біль
        public int? Chills_Symptom_Value { get; set; } // Озноб
        public int? Light_Fear_Symptom_Value { get; set; } // Світлобоязнь
    }
}
