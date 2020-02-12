using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class AddXp : MonoBehaviour
{
    public Text xpForce;
    public Text xpAgi;
    public Text xpVitesse;
    public Text xpEndu;
    private int force, agi, vitesse, endu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void updateStat(int value)
    {
        if(value == 4)
        {
            force += 2;
            endu += 2;
            xpForce.text = "FORCE: " + force;
            xpEndu.text = "ENDU: " + endu;
        }
        else if ( value==5 )
        {
            agi += 2;
            vitesse += 3;
            xpAgi.text = "AGI: " + agi;
            xpVitesse.text = "VITESSE: " + vitesse;
        }
        else if(value==70)
        {
            force += 17;
            agi += 28;
            vitesse += 7;
            endu += 18;
            xpForce.text = "FORCE: " + force;
            xpEndu.text = "ENDU: " + endu;
            xpAgi.text = "AGI: " + agi;
            xpVitesse.text = "VITESSE: " + vitesse;
        }

    }

    public void saveData()
    {
        Datas datas = new Datas();
        datas.force = force;
        datas.agi = agi;
        datas.vitesse = vitesse;
        datas.endu = endu;
        DataManager.save(datas, "MaSave");
    }
    public void loadData()
    {
        Datas datas = (Datas)DataManager.Load("MaSave");

        force = datas.force;
        agi = datas.agi;
        vitesse = datas.vitesse;
        endu = datas.endu;

        xpForce.text = "FORCE: " + force;
        xpEndu.text = "ENDU: " + endu;
        xpAgi.text = "AGI: " + agi;
        xpVitesse.text = "VITESSE: " + vitesse;



    }
    // Update is called once per frame

}
