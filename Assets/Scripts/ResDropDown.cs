using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ResDropDown : MonoBehaviour
{


    public int width;
    public int height;

    //todo have this as a conf.txt file
    List<string> res = new List<string>() {"Select", "800 x 600", "1024 x 768", "2048 x 1536"};

    public Dropdown dropdown;
    public string selectedRes;






    public void Dropdown_IndexChanged(int index){

        selectedRes = res[index];

       // Debug.Log(selectedRes);
        string [] ress = selectedRes.Split(' ');

       // Debug.Log("ress");

        //string toRemove = 'x';

        //ress = ress.Where(val => val != toRemove).ToArray();



        var resss = new List<string>(ress);
        resss.Remove("x");


        width = int.Parse(resss[0]);
        height = int.Parse(resss[1]);

        //Screen.SetResolution(width,height,false);


    }

    void Start(){

        PopulateList();
        Debug.Log("start");



    }



    void PopulateList(){

        //List<string> names = new List<string>() {"Fred", "Barney"};
        dropdown.AddOptions(res);
        //Debug.Log("List PopulateList");


    }



    public void SetRes(){
    //void Update(){

      Screen.SetResolution(width,height, false);
      // Debug.Log("Res set");
}








}
