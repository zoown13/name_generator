using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;



public class NameGenerator : MonoBehaviour
{
     

    

    public void Generate_name()
    {
        string[] location = {"화산","태평양","수산시장","심연","천공","동굴","해저","무기시장","암시장","앞마당","학교","교회","절"
        ,"소행성:","화성","태양","산","호수","옷장","개집","운동장","쇼핑센터","놀이공원","목욕탕","무너진도시","쓰레기장","공원","경찰서","소방서","호수"};
        string[] attribute = {"구불구불한","구린내나는","날카로운","뜨거운","부드러운","비린내나는","슬픈","울부짖는","예쁜","조그만"
        ,"시퍼런","무딘","불타오르는","한기가나는","진동하는","솟아오르는","유연한","탄력있는","빛이나는","물컹물컹한","거대한","정밀한","오염된","성스러운","시끄러운","활발한","저주받은","육중한","가벼운","약해진" };
        string[] weapon = {"버클러","타지","헝가리 방패","장궁","석궁","각궁","단궁","빌","랜스","파이크","하스타","알슈피스","할베르트","글레이브","사리사","극","당파","바르디슈",
"대거","크리스","쿠크리","패링 대거","스틸레토","롱소드","시미타","마체테","봉","기관단총","돌격소총","권총"};
        string name;

        int index = Random.Range(0, 29);
        string name_loc = location[index];
        index = Random.Range(0, 29);
        string name_attribute = attribute[index];
        index = Random.Range(0, 29);
        string name_weapon = weapon[index];

        name = name_attribute + " " + name_loc + " " + name_weapon;

        using (StreamWriter outputFile = new StreamWriter(@"WeaponName.txt",true))
        {
            
                outputFile.WriteLine(name);
            
        }


    }

  
   



   
}
