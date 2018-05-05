using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Restaurant
{

    private int id;
    private string name;
    private string image;
    private string address;
    private double latitude;
    private double longitude;
    private double rating;
    private double distanceFromUser;
    private string additionalInformation;
    private ArrayList gallery;
    private string suburb;
    private ArrayList cuisinesList;
    private string halalnessLevel;
    private string supplier;
    private string proofHalalImage;
    private string phoneNumber;

    public Restaurant(int id, string name, string image, string address, double latitude, double longitude, double rating, double distanceFromUser, string additionalInformation, string suburb, string halalnessLevel, string supplier, string proofHalalImage, string phoneNumber)
    {
        this.id = id;
        this.name = name;
        this.image = image;
        this.address = address;
        this.latitude = latitude;
        this.longitude = longitude;
        this.rating = rating;
        this.distanceFromUser = distanceFromUser;
        this.additionalInformation = additionalInformation;
        gallery = new ArrayList();
        this.suburb = suburb;
        cuisinesList = new ArrayList();
        this.halalnessLevel = halalnessLevel;
        this.supplier = supplier;
        this.proofHalalImage = proofHalalImage;
        this.phoneNumber = phoneNumber;
    }

    public int GetId()
    {
        return id;
    }

    public void SetId(int id)
    {
        this.id = id;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetImage()
    {
        return image;
    }

    public void SetImage(string image)
    {
        this.image = image;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public double GetLatitude()
    {
        return latitude;
    }

    public void SetLatitude(double latitude)
    {
        this.latitude = latitude;
    }

    public double GetLongitude()
    {
        return longitude;
    }

    public void SetLongitude(double longitude)
    {
        this.longitude = longitude;
    }

    public double GetRating()
    {
        return rating;
    }

    public void SetRating(double rating)
    {
        this.rating = rating;
    }

    public double GetDistanceFromUser()
    {
        return distanceFromUser;
    }

    public void SetDistanceFromUser(double distanceFromUser)
    {
        this.distanceFromUser = distanceFromUser;
    }

    public string GetAdditionalInformation()
    {
        return additionalInformation;
    }

    public void SetAdditionalInformation(string additionalInformation)
    {
        this.additionalInformation = additionalInformation;
    }

    public ArrayList GetGallery()
    {
        return gallery;
    }

    public void SetGallery(ArrayList gallery)
    {
        this.gallery.Clear();
        for (int i = 0; i < gallery.Count; i++)
        {
            this.gallery.Add(gallery[i]);
        }//end for
    }

    public string GetSuburb()
    {
        return suburb;
    }

    public void SetSuburb(string suburb)
    {
        this.suburb = suburb;
    }

    public ArrayList GetCuisines()
    {
        return cuisinesList;
    }

    public void SetCuisines(ArrayList cuisines)
    {
        this.cuisinesList.Clear();
        for (int i = 0; i < cuisines.Count; i++)
        {
            this.cuisinesList.Add(cuisines[i]);
        }//end for
    }

    public string GetHalalnessLevel()
    {
        return halalnessLevel;
    }

    public void SetHalalnessLevel(string halalnessLevel)
    {
        this.halalnessLevel = halalnessLevel;
    }

    public string GetSupplier()
    {
        return supplier;
    }

    public void SetSupplier(string supplier)
    {
        this.supplier = supplier;
    }

    public string GetProofHalalImage()
    {
        return proofHalalImage;
    }

    public void SetProofHalalImage(string proofHalalImage)
    {
        this.proofHalalImage = proofHalalImage;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }



}
