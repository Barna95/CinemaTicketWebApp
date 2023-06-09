﻿using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModels
{

    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie Start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required")]
        public MovieCategory MovieCategory { get; set; }

        // Extras
        [Display(Name = "Select Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public double Rating { get; set; }

        [Display(Name = "Select PreviewLink")]
        [Required(ErrorMessage = "PreviewLink is required")]
        public string PreviewLink { get; set; }

        [Display(Name = "Select Language")]
        [Required(ErrorMessage = "Language is required")]
        public Language Language { get; set; }

        [Display(Name = "Select Budget")]
        [Required(ErrorMessage = "Budget is required")]
        public decimal Budget { get; set; }

        [Display(Name = "Select RunTime")]
        [Required(ErrorMessage = "RunTime is required")]
        public string RunTime { get; set; }


        //Relationships
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select cinema")]
        [Required(ErrorMessage = "Movie cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select producer")]
        [Required(ErrorMessage = "Movie producer is required")]
        public int ProducerId { get; set; }

    }
}
