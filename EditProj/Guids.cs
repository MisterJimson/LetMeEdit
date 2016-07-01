// Guids.cs
// MUST match guids.h
using System;

namespace rdomunozcom.EditProj
{
    static class GuidList
    {
        public const string guidEditProjPkgString = "67374493-7f41-4665-bb0f-9ce9ede3fe7b";
        public static Guid EditProjCmdSetId => Guid.Parse("d2f70dae-9a2d-47e1-a470-7354a552821c");
        public static Guid EditSlnCmdSetId => Guid.Parse("4cad5c42-61dd-47f9-a605-bb9c469dc962");
    };
}