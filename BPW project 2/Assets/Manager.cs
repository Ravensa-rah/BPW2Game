using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject Book, Watch, Sweater, Headphones, Picture, TrainTick, BookB, TrainTickB, SweaterB, HeadphonesB, continueButton, BookTekst,SweaterTekst, HeadphonesTekst, WatchTekst, PictureTekst, TrainTickTekst;

    Vector2 BookInitialPos, WatchInitialPos, SweaterInitialPos, HeadphonesInitialPos, PictureInitialPos, TrainTickInitialPos;

    public AudioSource Fire,Pages,Tick,Song,Pic,Train;

    bool Fireplayed, Pagesplayed, Tickplayed, Songplayed, Picplayed, Trainplayed;
    bool BookCorrect, SweaterCorrect, HeadphonesCorrect, WatchCorrect, PictureCorrect, TrainTickCorrect = false;

    private void Start()
    {
        BookInitialPos = Book.transform.position;
        WatchInitialPos = Watch.transform.position;
        SweaterInitialPos = Sweater.transform.position;
        HeadphonesInitialPos = Headphones.transform.position;
        PictureInitialPos = Picture.transform.position;
        TrainTickInitialPos = TrainTick.transform.position;
        continueButton.SetActive(false);
        BookTekst.SetActive(false);
        SweaterTekst.SetActive(false);
        HeadphonesTekst.SetActive(false);
        WatchTekst.SetActive(false);
        PictureTekst.SetActive(false);
        TrainTickTekst.SetActive(false);

    }


    public void ContinueGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void DragBook()
    {
        Book.transform.position = Input.mousePosition;
        BookTekst.SetActive(true);
        if (!Pages.isPlaying && !Pagesplayed)
        {
            Pagesplayed = true;
            Pages.Play();
        }
    }
    public void DragWatch()
    {
        Watch.transform.position = Input.mousePosition;
        WatchTekst.SetActive(true);
        if (!Tick.isPlaying && !Tickplayed)
        {
            Tickplayed = true;
            Tick.Play();
        }
    }
    public void DragSweater()
    {
        Sweater.transform.position = Input.mousePosition;
        SweaterTekst.SetActive(true);

        if (!Fire.isPlaying && !Fireplayed)
        {
            Fireplayed = true;
            Fire.Play();
        }
    }
    public void DragTrainTick()
    {
        TrainTick.transform.position = Input.mousePosition;
        TrainTickTekst.SetActive(true);

        if (!Train.isPlaying && !Trainplayed)
        {
            Trainplayed = true;
            Train.Play();
        }
    }
    public void DragHeadphones()
    {
        Headphones.transform.position = Input.mousePosition;
        HeadphonesTekst.SetActive(true);
        if (!Song.isPlaying && !Songplayed)
        {
            Songplayed = true;
            Song.Play();
        }

    }
    public void DragPicture()
    {
        Picture.transform.position = Input.mousePosition;
        PictureTekst.SetActive(true);
        if (!Pic.isPlaying && !Picplayed)
        {
            Picplayed = true;
            Pic.Play();
        }
    }






    public void DropPicture()
    {
        
        {
            Picture.transform.position = PictureInitialPos;
            PictureTekst.SetActive(false);
        }

    }

    public void DropBook()
    {
        float Distance = Vector3.Distance(Book.transform.position, BookB.transform.position);
        if (Distance < 50)
        {
            Book.transform.position = BookB.transform.position;
            BookCorrect = true;
        }
        else
        {
            Book.transform.position = BookInitialPos;
        }
        BookTekst.SetActive(false);
    }

    public void DropWatch()
    {
        Watch.transform.position = WatchInitialPos;
        WatchTekst.SetActive(false);
    }

    public void DropSweater()
    {
        float Distance = Vector3.Distance(Sweater.transform.position, SweaterB.transform.position);
        if (Distance < 50)
        {
            Sweater.transform.position = SweaterB.transform.position;
            SweaterCorrect = true;
        }
        else
        {
            Sweater.transform.position = SweaterInitialPos;
        }
        SweaterTekst.SetActive(false);
    }
    public void DropTrainTick()
    {
        float Distance = Vector3.Distance(TrainTick.transform.position, TrainTickB.transform.position);
        if (Distance < 50)
        {
            TrainTick.transform.position = TrainTickB.transform.position;
            TrainTickCorrect = true;
        }
        else
        {
            TrainTick.transform.position = TrainTickInitialPos;
        }
        TrainTickTekst.SetActive(false);
    }

    public void DropHeadphones()
    {
        float Distance = Vector3.Distance(Headphones.transform.position, HeadphonesB.transform.position);
        if (Distance < 50)
        {
            Headphones.transform.position = HeadphonesB.transform.position;
            HeadphonesCorrect = true;
        }
        else
        {
            Headphones.transform.position = HeadphonesInitialPos;
        }
        HeadphonesTekst.SetActive(false);
    }

    

    void Update()
    {

        if (BookCorrect && SweaterCorrect && HeadphonesCorrect && TrainTickCorrect)
        {
            continueButton.SetActive(true);
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
