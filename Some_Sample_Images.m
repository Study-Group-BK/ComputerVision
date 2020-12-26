%% Peppers
rgbImage = imread('peppers.png'); %or 'onion.png'
grayImage = rgb2gray(rgbImage);
imwrite(grayImage,'grayPeppers.png');
imshow(rgbImage)

%% Mandrill
storedStructure = load('mandrill.mat')
rgbImage = ind2rgb(storedStructure.X, storedStructure.map);
grayImage = rgb2gray(rgbImage);
imshow(grayImage);
imwrite(grayImage, 'grayMandrill.png');

%% List of MATLAB sample images
           AT3_1m4_01.tif            AT3_1m4_02.tif
           AT3_1m4_03.tif            AT3_1m4_04.tif
           AT3_1m4_05.tif            AT3_1m4_06.tif
           AT3_1m4_07.tif            AT3_1m4_08.tif
           AT3_1m4_09.tif            AT3_1m4_10.tif
               autumn.tif                   bag.png
                blobs.png                 board.tif
            cameraman.tif                 canoe.tif
                 cell.tif                circbw.tif
              circles.png               circuit.tif
                coins.png         concordaerial.png
    concordorthophoto.png                 eight.tif
               fabric.png              football.jpg
               forest.tif           gantrycrane.png
                glass.png                greens.jpg
              hestain.png                  kids.tif
          liftingbody.png                  logo.tif
                  m83.tif                 mandi.tif
                 moon.tif                   mri.tif
             office_1.jpg              office_2.jpg
             office_3.jpg              office_4.jpg
             office_5.jpg              office_6.jpg
                onion.png                paper1.tif
                pears.png               peppers.png
             pillsetc.png                  pout.tif
                 rice.png                saturn.png
               shadow.tif            snowflakes.png
                spine.tif                  tape.png
             testpat1.png                  text.png
                 tire.tif                tissue.png
                trees.tif     westconcordaerial.png
westconcordorthophoto.png
