## Library Collision
* Comment out these lines in "Engine\Plugins\Runtime\OpenCV\Source\ThirdParty\OpenCV\include\opencv2\core\utility.hpp"
	* 52 = #if defined(check)
	* 53 = # warning Detected Apple 'check' macro definition, it can cause build conflicts. Please, include this header before any Apple headers.
	* 54 = #endif
	* 934 = bool check() const;