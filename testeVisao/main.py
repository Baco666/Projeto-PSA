import numpy as np
import cv2

#definir cor vermelha
# red_lower = np.array([136, 87, 111], np.uint8)
# red_upper = np.array([180, 255, 255], np.uint8)

red_lower = np.array([0, 100, 100], np.uint8)
red_upper = np.array([10, 255, 255], np.uint8)

# red_lower = np.array([160, 100, 100], np.uint8)
# red_upper = np.array([180, 255, 255], np.uint8)

#definir cor amarela
yellow_lower = np.array([5, 50, 50], np.uint8)
yellow_upper = np.array([15, 255, 255], np.uint8)

# yellow_lower = np.array([15,100,100], np.uint8)
# yellow_upper = np.array([35,255,255], np.uint8)

# yellow_lower = np.array([15, 150, 150], np.uint8)
# yellow_upper = np.array([35, 255, 255], np.uint8)

def red_light_test():
    #ligar camera
    video = cv2.VideoCapture(0)

    while True:
        #definir luz não detectada
        light_detected = False

        #criar frame da camera
        ret, frame = video.read()

        #converter espaço de cores
        hsv_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)
        #cv2.imshow("hsv", hsv_frame)

        #criar mascara para identificar o espaço de cor especificado
        red_mask = cv2.inRange(hsv_frame, red_lower, red_upper)
        #cv2.imshow("mask", red_mask)

        kernal = np.ones((5, 5), "uint8")

        red_mask = cv2.dilate(red_mask, kernal)
        res_red = cv2.bitwise_and(frame, frame, mask=red_mask)
        #cv2.imshow("mask2", red_mask)
        #cv2.imshow("result", res_red)

        #identificar a região
        contours, hierarchy = cv2.findContours(red_mask, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

        for pic, contour in enumerate(contours):
            area = cv2.contourArea(contour)
            if area > 300:
                x, y, w, h = cv2.boundingRect(contour)
                frame = cv2.rectangle(frame, (x, y), (x + w, y + h), (0, 0, 255), 2)
                cv2.putText(frame, "Red Light Detected", (x, y), cv2.FONT_HERSHEY_SIMPLEX, 1.0, (0, 0, 255))

        #mostrar video após todas as etapas
        cv2.imshow("Color Detection", frame)

        #identificar se a luz está ou não ok
        M = cv2.moments(red_mask)
        if M["m00"] != 0 and not light_detected:
            cX = int(M["m10"] / M["m00"])
            cY = int(M["m01"] / M["m00"])
            cv2.circle(res_red, (cX, cY), 5, (255, 0, 0), -1)
            #light_detected = True
            print('LUZ DETECTADA')

        elif M["m00"] == 0 and not light_detected:
            print('LUZ NÃO DETECTADA')

        if cv2.waitKey(10) & 0xFF == ord(' '):
            break

#criar função para detectar luz amarela
def yellow_light_test():
    video = cv2.VideoCapture(0)

    while True:
        light_detected = False

        ret, frame = video.read()

        hsv_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)

        yellow_mask = cv2.inRange(hsv_frame, yellow_lower, yellow_upper)

        kernal = np.ones((5, 5), "uint8")

        yellow_mask = cv2.dilate(yellow_mask, kernal)
        res_yellow = cv2.bitwise_and(frame, frame, mask=yellow_mask)

        contours, hierarchy = cv2.findContours(yellow_mask, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

        for pic, contour in enumerate(contours):
            area = cv2.contourArea(contour)
            if area > 300:
                x, y, w, h = cv2.boundingRect(contour)
                frame = cv2.rectangle(frame, (x, y), (x + w, y + h), (0, 165, 255), 2)
                cv2.putText(frame, "Yellow Light Detected", (x, y), cv2.FONT_HERSHEY_SIMPLEX, 1.0, (0, 165, 255))

        cv2.imshow("Color Detection", frame)

        M = cv2.moments(yellow_mask)
        if M["m00"] != 0 and not light_detected:
            cX = int(M["m10"] / M["m00"])
            cY = int(M["m01"] / M["m00"])
            cv2.circle(res_yellow, (cX, cY), 5, (255, 0, 0), -1)
            # light_detected = True
            print('LUZ OK')

        elif M["m00"] == 0 and not light_detected:
            print('LUZ NÃO OK')

        if cv2.waitKey(10) & 0xFF == ord(' '):
            break

#chamar as funções
red_light_test()
red_light_test()
yellow_light_test()
red_light_test()
