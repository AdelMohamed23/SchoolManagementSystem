﻿using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Mapping.StudentMapping
{
    public partial class StudentProfile
    {
        public void EditStudentCommandMapping()
        {
            CreateMap<EditStudentCommand, Student>()
               .ForMember(dest => dest.DID, opt => opt.MapFrom(src => src.DepartmementId))
               .ForMember(dest => dest.NameAr, opt => opt.MapFrom(src => src.NameInArbic))
               .ForMember(dest => dest.NameEn, opt => opt.MapFrom(src => src.NameInEnglish))
               .ForMember(dest => dest.StudID, opt => opt.MapFrom(src => src.Id));
        }
    }
}
