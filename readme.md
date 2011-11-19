# GeoNAN

GeoNAN is a lightweight geospatial data server written in .NET using [Nancy](http://www.nancyfx.org/). By using Nancy the desire is to support running GeoNAN on [Mono](http://mono-project.com). The goal of GeoNAN is to be simple to use and reduce the technical and financial cost compared to other geospatail data servers.

## Supported:

* ESRI's published [GeoServices REST specification](http://www.esri.com/industries/landing-pages/geoservices/geoservices.html)
* [Spatialite](http://www.gaia-gis.it/spatialite/) geodatabases
* Point geometries only

## Future support

* [GeoJSON](http://geojson.org/)
* [PostGIS](http://postgis.refractions.net/)
* More geometry types

## Other tools

I am choosing not to include the Spatialite tools.  If you need these tools, please follow the link above.  The Spatialite GUI is very useful
and is the tool used to create the spatialite database.  There is also a lightweight GIS viewer that can also be downloaded on the Spatialite
website for viewing the data.

## Copyright

Copyright © 2011 Jamie Phillips

## License

GeoNAN is licensed under [BSD](http://www.opensource.org/licenses/bsd-license.php "Read more about the BSD license form"). Refer to license.txt for more information.
