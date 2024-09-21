        [Column(TypeName = "NVARCHAR", Order = 3)]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un máximo de 30 caracteres y un mínimo de 3 caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Nombre")]
        [Index("IX_Nombre_CalificacionActividad", IsClustered = false, IsUnique = false)]
        public string Nombre { get; set; }