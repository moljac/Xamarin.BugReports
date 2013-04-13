# Solution appears twice in Solution Explorer #

This started with one older solution with some odd errors, so I have reduced to bare minimum
to see whether problem lies in sln file.

Xamarin Studio empty sln file

      Microsoft Visual Studio Solution File, Format Version 11.00
      # Visual Studio 2010
      Global
         GlobalSection(SolutionConfigurationPlatforms) = preSolution
            Debug|Any CPU = Debug|Any CPU
            Release|Any CPU = Release|Any CPU
         EndGlobalSection
         GlobalSection(ProjectConfigurationPlatforms) = postSolution
         EndGlobalSection
      EndGlobal

My empty solution file from Windows Box:


      Microsoft Visual Studio Solution File, Format Version 11.00
      # Visual Studio 2010
      Global
         GlobalSection(SolutionConfigurationPlatforms) = preSolution
            HideSolutioNode = FALSE
         EndGlobalSection
      EndGlobal


Both load solution, but it appears as 2 solution nodes in Solution explorer.

Image

Log